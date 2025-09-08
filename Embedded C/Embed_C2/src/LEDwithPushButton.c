#include <avr/io.h>
#include <util/delay.h>

#define LED_PIN PD5
#define Push_Button PD3
int main(void){
    DDRD |= (1<<LED_PIN);
    DDRD &= ~(1<<Push_Button);
    PORTD |= (1<<Push_Button);
    while(1){

        if(!(PIND & (1<<Push_Button))){
            PORTD |= (1 << LED_PIN);
            _delay_ms(200);
            PORTD &= ~(1 << LED_PIN);
            _delay_ms(500);
        }
        else{
            PORTD &= ~(1 << LED_PIN);
            _delay_ms(500);
        }
        
    }
}