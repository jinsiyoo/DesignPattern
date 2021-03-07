# 生成器模式 (Builder pattern)

> 又名：建造者模式

## 解決何種問題？

將某種類產品的生產步驟整理出來。
所有要生產這類產品的類別(class)均要實現這些標準化步驟。
避免實際生產時遺漏任一個步驟，統一由一個類別執行系列的生產步驟。

## 使用工廠模式的成果

未使用生產器模式：

```csharp
    // 未依循生成器模式時，生產步驟必須依序呼叫，而且不能遺漏任一個程序
    OldFashion drink1 = new OldFashion();
    drink1.GetContainer();
    drink1.AddIngredients();
    drink1.Mix();
    drink1.Done();

    Martini drink2 = new Martini();
    drink2.GetContainer();
    drink2.AddIngredients();
    drink2.Mix();
    drink2.Done();
    
```

> 設計的缺陷 :
> 產品生成的過程都必須小心謹慎，遺漏或順序錯亂會生成錯誤的結果
> 生產同類型產品過程未有標準化，導致管理成本高。

使用工廠模式：

```csharp
    // 實作調酒師(主導者)
    DrinkDirector bartender = new Bartender();
    
    // 跟調酒師點一杯古典雞尾酒
    bartender.GetOrder(new OldFashion());

    // 由調酒師製作
    bartender.MakeOrder();

    // 跟調酒師點一杯馬丁尼
    bartender.GetOrder(new Martini());

    // 由調酒師製作
    bartender.MakeOrder();

```

> 不管你要點哪一種調酒，你都不需要知道製作的過程。調酒師會遵循一套標準的流程，為你製作調酒。
> 另外如果要調整或是增加品項，都不需要修改到調酒師(DrinkDirector)這個類別。
> 除非修改調酒這套標準流程，但也比之前容易許多 (每一個實作調酒的程式都要修改)。

### 輸出結果

```text
Get a old fashion glass.
Add whiskey, Angostura bitters, sugar, ice and lemon-peel.
Mix with small bar-spoon.
Leaving spoon in glass.
Get a cocktail glass.
Add Boker's bitters, Maraschino, Old Tom gin and ice.
Shake up thoroughly.
Strain into a cocktail glass.
```

## 優點

1. 生產統一個同由一個類別負責，將複雜的生產過程標準流程化。
2. 用戶不需要知道生產過程或細節，只需要指定生產的類別就可以得到結果。

## UML

[![UML](\../../../images/W3sDesign_Builder_Design_Pattern_UML.jpg "W3sDesign_Factory_Method_Design_Pattern_UML")](https://en.wikipedia.org/wiki/Builder_pattern#/media/File:W3sDesign_Builder_Design_Pattern_UML.jpg)

## 如何使用?

1. 建立 *生成器抽象介面*，定義裝配的 *抽象介面*。
2. 建立一個或N個 *具體生成器*，實現 *生成器抽象介面*。
3. 建立 *主導者*，並使用 *生成器抽象介面*。
