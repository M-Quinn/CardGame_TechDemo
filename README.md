# Card Game | Tech Demo #
<p>A system to dynamically create 105 unique cards from 14 C# classes and a single prefab. You can check out the published article <a href="https://medium.com/unity-coder-corner/unity-creating-a-card-game-ac7f46365a50?sk=6150104ae98e57090f35ba3090e29bb7">on Medium</a></p>

![Unity_dSfgKOECEM](https://github.com/user-attachments/assets/715be121-6f69-4142-8b76-4a1ac1c32aba)

## Description ##
Built in Unity 6, this small tech demo was made to demonstrate the ability to quickly and easily create a card game <b>dynamically</b>.
In most Unity projects, developers will create prefabs or scriptable objects for every single instance of a type of card. Although this does work, it adds a ton of time, overhead, and removes the ability to randomly create cards.

This project utilizes the Decorator Pattern to dynamically create cards using a base item type and multiple modifiers. You can find these items and modifiers inside the project Assets>Card>Scripts. Inside this folder you will find Items and ItemDecorators.

## License ##
This project is under the MIT license and is allowed to be forked for personal or commercial use.
