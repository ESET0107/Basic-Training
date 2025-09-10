#include <Arduino.h>
#include <avr/io.h>
#include <util/delay.h>

#define DATA_PIND4 PB2
#define DATA_PIND5 PB1
#define DATA_PIND6 PB0
#define DATA_PIND7 PD7
#define EN PB3
#define DATA_RS PB4

void lcd_pulse(){
    PORTB |= (1<<EN);
    _delay_ms(10);
    PORTB &= ~(1<<EN);
    _delay_ms(20);
}
void lcd_command(unsigned char cmd){
    PORTB &= ~(1<<DATA_RS);
    //Displaying text - High Nibble
    if(cmd & 0x10){PORTB |= (1<<DATA_PIND4);}else{PORTB &= ~(1<<DATA_PIND4);}
    if(cmd & 0x20){PORTB |= (1<<DATA_PIND5);}else{PORTB &= ~(1<<DATA_PIND5);}
    if(cmd & 0x40){PORTB |= (1<<DATA_PIND6);}else{PORTB &= ~(1<<DATA_PIND6);}
    if(cmd & 0x80){PORTD |= (1<<DATA_PIND7);}else{PORTD &= ~(1<<DATA_PIND7);}
    lcd_pulse();
    //Accepting commands - Low Nibble
    if(cmd & 0x01){PORTB |= (1<<DATA_PIND4);}else{PORTB &= ~(1<<DATA_PIND4);}
    if(cmd & 0x02){PORTB |= (1<<DATA_PIND5);}else{PORTB &= ~(1<<DATA_PIND5);}
    if(cmd & 0x04){PORTB |= (1<<DATA_PIND6);}else{PORTB &= ~(1<<DATA_PIND6);}
    if(cmd & 0x08){PORTD |= (1<<DATA_PIND7);}else{PORTD &= ~(1<<DATA_PIND7);}
    lcd_pulse();
}
void lcd_data(unsigned char data){
    PORTB |= (1<<DATA_RS);
    //Displaying text - High Nibble
    if(data & 0x10){PORTB |= (1<<DATA_PIND4);}else{PORTB &= ~(1<<DATA_PIND4);}
    if(data & 0x20){PORTB |= (1<<DATA_PIND5);}else{PORTB &= ~(1<<DATA_PIND5);}
    if(data & 0x40){PORTB |= (1<<DATA_PIND6);}else{PORTB &= ~(1<<DATA_PIND6);}
    if(data & 0x80){PORTD |= (1<<DATA_PIND7);}else{PORTD &= ~(1<<DATA_PIND7);}
    lcd_pulse();
    //Accepting commands - Low Nibble
    if(data & 0x01){PORTB |= (1<<DATA_PIND4);}else{PORTB &= ~(1<<DATA_PIND4);}
    if(data & 0x02){PORTB |= (1<<DATA_PIND5);}else{PORTB &= ~(1<<DATA_PIND5);}
    if(data & 0x04){PORTB |= (1<<DATA_PIND6);}else{PORTB &= ~(1<<DATA_PIND6);}
    if(data & 0x08){PORTD |= (1<<DATA_PIND7);}else{PORTD &= ~(1<<DATA_PIND7);}
    lcd_pulse();
}
void lcd_init(){
    _delay_ms(20);
    lcd_command(0x02);
    lcd_command(0x28);
    lcd_command(0x0C);
    lcd_command(0x06);
    lcd_command(0x01);
    _delay_ms(20);
}
void lcd_print(char *str){
    while(*str){
        lcd_data(*str++);
    }
}
int main(void){
    DDRB = 0xFF;
    DDRD |= (1<<DATA_PIND7);
    lcd_init();

    lcd_command(0x80);
    lcd_print("Hisashiburidana");

    lcd_command(0xC0);
    lcd_print("    Zenitsu");

    while(1){ }
}

