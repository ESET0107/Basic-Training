#include <..\hal_gpio.h>

void gpio_init(){
    DDRD |= (1<<LED_PIN);
    DDRD &= ~(1<<Push_Button);
    PORTD |= (1<<Push_Button);
}

void gpio_toggle(){
    PORTD ^= (1 << LED_PIN);
}

void set_bit(){
    PORTD |= (1 << LED_PIN);
    _delay_ms(200);
}

void clear_bit(){
    PORTD &= ~(1 << LED_PIN);
    _delay_ms(500);
}