นางสาวอรณัญช์ ไกรอ่ำ
683450197-1

## Class Diagram
```mermaid
classDiagram
    class CoffeeMachine {
        -int water
        -int coffee
        -int milk
        -int chocolate
        +CoffeeMachine(int water, int coffee, int milk, int chocolate)
        -CheckAndFill(int w, int c, int m, int choco)
        +BuyBlackCoffee()
        +BuyMocha()
        +BuyLatte()
        +BuyChocolate()
        +ShowStock()
    }