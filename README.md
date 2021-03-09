# 設計模式 *DesignPattern*

## 這是個什麼樣的專案?

- 個人用來記錄與學習 Design Patten 的練習專案
- 主要使用的程式語言是 CSharp (C#)
- 為降低學習門檻本專案使用單純的 Console Application 架構執行
- 盡可能避免引入第三方套件造成理解混亂

## 設計模式是什麼?

**設計模式**是針對軟體工程中普遍存在的問題，所提出的解決方案。

## 設計模式的分類?

根據 Gang of Four(GoF) 出版 *[Design Patterns](https://en.wikipedia.org/wiki/Design_Patterns) - Elements of Reusable Object-Oriented Software* 一書，收錄 23 種設計模式，依照應用可以分成三類：

1. 創建型模式 Creational Patterns
2. 結構型模式 Structural Patterns
3. 行為型模式 Behavioural Patterns

### Creational Patterns 創建型模式類

> 創建型模式是跟物件創立（object creation）的過程有關的模式。
( 5 種)

- [x] [工廠模式 *Factory Method Pattern*](/Patterns/Creational/FactoryMethod/README.md)
- [x] [生成器模式 *Builder Pattern*](/Patterns/Creational/Builder/README.md)
- [x] [原型模式 *Prototype Pattern*] (/Patterns/Creational/Prototype/README.md)
- [ ] 單例模式 *Singleton Pattern*
- [ ] 抽象工廠 *Abstract Factory Pattern*

### 2. Structural Patterns 結構型模式類

> 結構型模式是跟類別／物件的組成（classes/objects composition）有關的模式。
( 7 種)

- [ ] 組合模式 *Composite Pattern*
- [ ] 裝飾模式 *Decorator Pattern*
- [ ] 適配器模式 *Adapter Pattern*
- [ ] 代理模式 *Proxy Pattern*
- [ ] 橋接模式 *Bridge Pattern*
- [ ] 外觀模式 *Facade Pattern*
- [ ] 享元模式 *Flyweight Pattern*

### 3. Behavioural Patterns 行為型模式類

> 行為型模式是跟類別／物件之間的互動與職責分配有關的模式。
( 12 種)

- [ ] 觀察者模式 *Observer Pattern*
- [ ] 模板方法模式 *Template Method Pattern*
- [ ] 策略模式 *Strategy Pattern*
- [ ] 解釋器模式 *Interpreter Pattern*
- [ ] 責任鏈模式 *Chain of Responsibility Pattern*
- [ ] 命令模式 *Command Pattern*
- [ ] 迭代器模式 *Iterator Pattern*
- [ ] 中介者模式 *Mediator Pattern*
- [ ] 備忘錄模式 *Memento Pattern*
- [ ] Null Object Pattern
- [ ] 狀態模式 *State Pattern*
- [ ] 訪問者模式 *Visitor Pattern*

---

## 如何使用 VSCode

### 安裝 VSCode

下載 [Visual Studio Code](https://code.visualstudio.com/download "下載適合您的版本進行安裝")

### 安裝 .NET SDK

本專案使用 [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0 "下載適合您的版本進行安裝")

> 軟體開發套件 (Software development kit，簡稱 SDK)

### 開始建立專案

1. 啟動 VScode
2. 選擇 __File -> Open Folder__
3. 建立新資料夾後，__Select Folder__ 做為專案使用
4. ``Ctrl + ` `` 顯示 __Terminal__
5. 建立 Console Application Project

        dotnet new console
6. 完成專案建立

### 執行專案

1. ``Ctrl + ` `` 顯示 __Terminal__
2. 執行專案

        dotnet run
