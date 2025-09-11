#include "hal_gpio.h"
#include <util/delay.h>
void HAL_GPIO_Init(volatile uint8_t *port, uint8_t pin, uint8_t direction) {
    volatile uint8_t *ddr = port - 1;
    if (direction == OUTPUT) {
        *ddr |= (1 << pin);
    } else {
        *ddr &= ~(1 << pin);
    }
}

// void HAL_GPIO_Write2(volatile uint8_t *port, uint8_t pin, uint8_t value) {
//     if (value == 1) {
//         *port |= (1 << pin);
//         _delay_ms(1000);
//         *port &= ~(1 << pin);
//         _delay_ms(1000);
//     }
//     else if(value == 2){
//         while(1){
//             *port |= (1 << pin);
//             _delay_ms(200);
//             *port &= ~(1 << pin);
//             _delay_ms(200);
//         }
//     }
//     else if(value == 3){
//         *port |= (1 << pin);
//     }
//     else {
//         *port &= ~(1 << pin);
//     }
// }

// void HAL_GPIO_Write1(volatile uint8_t *port, uint8_t pin, uint8_t value) {
//     while(1){
//         if (value) {
//             *port |= (1 << pin);
//             _delay_ms(200);
//             *port &= ~(1 << pin);
//             _delay_ms(200);
//         } else {
//             *port &= ~(1 << pin);
//         }
//     }
// }

void HAL_GPIO_Write(volatile uint8_t *port, uint8_t pin, uint8_t value) {
    if (value) {
        *port |= (1 << pin);
        
    } else {
        *port &= ~(1 << pin);
    }
}

void HAL_GPIO_Toggle(volatile uint8_t *port, uint8_t pin) {
    *port ^= (1 << pin);
}

uint8_t HAL_GPIO_Read(volatile uint8_t *port, uint8_t pin) {
    volatile uint8_t *pin_reg = port - 2;
    return ((*pin_reg) & (1 << pin)) ? 1 : 0;
}
