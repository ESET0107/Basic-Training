using System;
using System.Collections.Generic;

namespace DLMS
{
    // Represents a DLMS/COSEM Object
    public struct CosemObject
    {
        public string Name;       // Object name
        public byte[] ObisCode;   // OBIS code (6 bytes)
        public ushort ShortName;  // Short Name referencing
        public int Value;         // Object value

        public CosemObject(string name, byte[] obisCode, ushort shortName, int value)
        {
            Name = name;
            ObisCode = obisCode;
            ShortName = shortName;
            Value = value;
        }
    }

    public class DlmsService
    {
        private List<CosemObject> meterObjects = new List<CosemObject>();

        // Add new object
        public void AddObject(CosemObject obj)
        {
            meterObjects.Add(obj);
        }

        // Compare two OBIS codes
        private bool ObisMatch(byte[] obis1, byte[] obis2)
        {
            if (obis1.Length != obis2.Length) return false;
            for (int i = 0; i < obis1.Length; i++)
            {
                if (obis1[i] != obis2[i]) return false;
            }
            return true;
        }

        // ===== GET Service =====
        public int? DlmsGet(byte[] obis)
        {
            foreach (var obj in meterObjects)
            {
                if (ObisMatch(obis, obj.ObisCode))
                {
                    Console.WriteLine($"[GET] {obj.Name} = {obj.Value}");
                    return obj.Value;
                }
            }
            Console.WriteLine("[GET] OBIS not found.");
            return null;
        }

        // ===== SET Service =====
        public bool DlmsSet(byte[] obis, int newValue)
        {
            for (int i = 0; i < meterObjects.Count; i++)
            {
                if (ObisMatch(obis, meterObjects[i].ObisCode))
                {
                    var updated = meterObjects[i];
                    updated.Value = newValue;
                    meterObjects[i] = updated;

                    Console.WriteLine($"[SET] {updated.Name} updated to {updated.Value}");
                    return true;
                }
            }
            Console.WriteLine("[SET] OBIS not found.");
            return false;
        }

        // ===== ACTION Service =====
        public void DlmsAction(byte[] obis, string method)
        {
            if (method == "RESET")
            {
                Console.WriteLine("[ACTION] Resetting meter values...");
                for (int i = 0; i < meterObjects.Count; i++)
                {
                    var updated = meterObjects[i];
                    updated.Value = 0;
                    meterObjects[i] = updated;
                }
                Console.WriteLine("[ACTION] Reset complete.");
            }
            else if (method == "SYNC_TIME")
            {
                Console.WriteLine("[ACTION] Synchronizing meter clock to system time...");
                // Example: System time logic here
                DateTime now = DateTime.Now;
                Console.WriteLine($"[ACTION] Time synced to {now}");
            }
            else
            {
                Console.WriteLine("[ACTION] Unknown method.");
            }
        }

        // ===== READ (Short Name) =====
        public int? DlmsReadSN(ushort shortName)
        {
            foreach (var obj in meterObjects)
            {
                if (obj.ShortName == shortName)
                {
                    Console.WriteLine($"[READ-SN] Reading object with Short Name: 0x{shortName:X4} = {obj.Value}");
                    return obj.Value;
                }
            }
            Console.WriteLine($"[READ-SN] Short Name 0x{shortName:X4} not found.");
            return null;
        }

        // ===== WRITE (Short Name) =====
        public bool DlmsWriteSN(ushort shortName, int newValue)
        {
            for (int i = 0; i < meterObjects.Count; i++)
            {
                if (meterObjects[i].ShortName == shortName)
                {
                    var updated = meterObjects[i];
                    updated.Value = newValue;
                    meterObjects[i] = updated;

                    Console.WriteLine($"[WRITE-SN] Writing value {newValue} to Short Name: 0x{shortName:X4}");
                    return true;
                }
            }
            Console.WriteLine($"[WRITE-SN] Short Name 0x{shortName:X4} not found.");
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DlmsService service = new DlmsService();

            // Example OBIS codes
            byte[] obisVoltage = { 1, 0, 1, 8, 0, 255 };
            byte[] obisEnergy = { 1, 0, 2, 8, 0, 255 };

            // Add sample objects
            service.AddObject(new CosemObject("Voltage", obisVoltage, 0x0001, 230));
            service.AddObject(new CosemObject("Energy", obisEnergy, 0x0002, 5000));

            // GET Example
            service.DlmsGet(obisVoltage);

            // SET Example
            service.DlmsSet(obisVoltage, 240);

            // ACTION Example
            service.DlmsAction(obisEnergy, "RESET");
            service.DlmsAction(obisEnergy, "SYNC_TIME");

            // READ/WRITE SN Example
            service.DlmsReadSN(0x0001);
            service.DlmsWriteSN(0x0001, 245);
            service.DlmsReadSN(0x0001);
        }
    }
}