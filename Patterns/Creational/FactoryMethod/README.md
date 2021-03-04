# 工廠模式(Factory method pattern)

在物件導向中，工廠模式是創建型模式的一種，透過工廠方法實作物件。

> 什麼是工廠？
> 用來實作其他物件的物件稱之為工廠。

## 解決問題？

不需要立即使用建構函式實作物件，且容許不明確的物件，再透過延伸類別來進行延遲實作。
換言之創建物件之初不必立即實作，先宣告介面後續再透過工廠方法來實作物件。

## 使用工廠模式的成果

未使用工廠模式：

```csharp
    // 宣告蛋糕同時，立即呼叫建構函數實作物件
    var cake = new ChocolateCake();

    // 吃蛋糕
    cake.EatCake();
```

使用工廠模式：

```csharp
    // 工廠
    CakeFactory factory = new CakeFactory();

    // 介面 (不需要呼叫建構函式，也不需要指定明確的類別)
    IBirthdayCake cake;

    // 延遲實作，工廠實作物件
    cake = factory.GetCake(CakeType.Chocolate);

    // 吃蛋糕
    cake.EatCake();
```

> 顧客進入蛋糕店 (CakeFactoey) 想買生日蛋糕 (ICake) 回家慶祝家人生日。
> 店員知道來由後，提供顧客一本蛋糕型錄 (CakeType)。
> 顧客參考目錄以後，決定購買 (GetCake) 巧克力蛋糕作為生日蛋糕。
> 此時蛋糕店的蛋糕師傅製作巧克力蛋糕送到顧客手上，顧客拿回家和人享用蛋糕 (EatCake)。

### 輸出結果

```shell
Factory made a Chocolate Cake(6 servings).
ChocolateCake's candle has lighted. 
ChocolateCake's candle has blown. 
Ate a ChocolateCake. 5 servings left.
```

## 優點

1. 剛開始不需要指定明確的類別物件，只需要先宣告介面。
2. 允許延遲實作物件。

## 缺點

1. 新增不同條件時，須修改到類別的靜態方法。

## UML

[![UML](/Patterns/Creational/FactoryMethod/images/W3sDesign_Factory_Method_Design_Pattern_UML.jpg "W3sDesign_Factory_Method_Design_Pattern_UML")](https://en.wikipedia.org/wiki/Factory_method_pattern#/media/File:W3sDesign_Factory_Method_Design_Pattern_UML.jpg)

## 如何使用？

1. 定義一個建立物件的介面。
2. 讓實現此介面的類別來決定實例化哪一個類別。
3. 並且讓類別的實例化延遲到子類別中進行。
