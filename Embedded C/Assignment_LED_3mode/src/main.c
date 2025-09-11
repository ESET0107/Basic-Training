#include "hal/hal_gpio.h"
#include "../config/led_config.h"
#include <util/delay.h>

int main(void) {
    HAL_GPIO_Init(LED_PORT, LED_PIN, OUTPUT);
    HAL_GPIO_Init(BUTTON_PORT, BUTTON_PIN, INPUT);

    *(BUTTON_PORT) |= (1 << BUTTON_PIN);

    uint8_t led_state = 0;
    uint8_t last_button_state = 1;  // pull-up means idle state is HIGH

    while (1) {
        uint8_t button_state = HAL_GPIO_Read(BUTTON_PORT, BUTTON_PIN);

        // Simple debounce and edge detection
        if (!button_state && last_button_state) {
            led_state = (led_state + 1)%4;
            _delay_ms(50);  // debounce delay
        }
        last_button_state = button_state;
        
        if(led_state == 0){
            HAL_GPIO_Write(LED_PORT, LED_PIN,0);
        }
        else if(led_state == 1){
            HAL_GPIO_Toggle(LED_PORT, LED_PIN);
            _delay_ms(1000);
        }
        else if(led_state == 2){
            HAL_GPIO_Toggle(LED_PORT, LED_PIN);
            _delay_ms(200);
        }
        else{
            HAL_GPIO_Write(LED_PORT, LED_PIN,1);
        }
        _delay_ms(10);  // polling delay
    }
}    

