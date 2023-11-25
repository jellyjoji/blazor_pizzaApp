namespace BlazingPizza.Client;

public class OrderState
{
    public bool ShowingConfigureDialog { get; private set; }

    public Pizza ConfiguringPizza { get; private set; }

    public Order Order { get; private set; } = new Order();

// void(보이드) 는 리턴(return) 되는 타입이 없음을 의미한다. 즉 아무것도 리턴하지 않음을 선언해주는 것과 같다.

// 주문한 피자 보기 메서드
    public void ShowConfigurePizzaDialog(PizzaSpecial special)
{
    ConfiguringPizza = new Pizza()
    {
        Special = special,
        SpecialId = special.Id,
        Size = Pizza.DefaultSize,
        Toppings = new List<PizzaTopping>(),
    };

    ShowingConfigureDialog = true;
}

// 주문한 피자 취소 메서드
public void CancelConfigurePizzaDialog()
{
    ConfiguringPizza = null;

    ShowingConfigureDialog = false;
}

// 주문한 피자 확인 메서드
public void ConfirmConfigurePizzaDialog()
{
    Order.Pizzas.Add(ConfiguringPizza);
    ConfiguringPizza = null;

    ShowingConfigureDialog = false;
}



// 주문한 피자 제거 메서드
public void RemoveConfiguredPizza(Pizza pizza)
{
    Order.Pizzas.Remove(pizza);
}
public void ResetOrder()
{
    Order = new Order();
}
}


