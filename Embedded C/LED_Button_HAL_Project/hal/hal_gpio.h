#ifndef HAL_GPIO_H
#define HAL_GPIO_H

#include <avr/io.h>
#define INPUT 0
#define OUTPUT 1

void gpio_init();
void set_bit();
void gpio_toggle();
void clear_bit();

#endif