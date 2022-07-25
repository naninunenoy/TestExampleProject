# TestExampleProject
## BitCounter

### 動作例
[Video.webm](https://user-images.githubusercontent.com/15327448/180803611-6227071e-d51b-47eb-89f0-4b6ef96b554d.webm)

### 説明
#### WithoutTestProject

Unityでよくある実装で、ではシーン上の `MonoBehaviour` にすべての参照と全ての処理が書かれており、テストを実装する余地がない。

* [Assets/WithoutTestProject/SampleScene.cs](https://github.com/naninunenoy/TestExampleProject/blob/main/Assets/WithoutTestProject/SampleScene.cs)

#### WithTestProject

ビットの状態から数値を計算する処理が [BitsToString.cs](https://github.com/naninunenoy/TestExampleProject/blob/main/Assets/WithTestProject/Scripts/BitsToString.cs)に委譲されており、テストも実装されている

* [Assets/WithTestProject/Scripts/Tests/BitsToStringTest.cs](https://github.com/naninunenoy/TestExampleProject/blob/main/Assets/WithTestProject/Scripts/Tests/BitsToStringTest.cs)

コツ？はシーン上の `MonoBehaviour` での実装を最小限にすること。

* [Assets/WithTestProject/SampleScene.cs](https://github.com/naninunenoy/TestExampleProject/blob/main/Assets/WithTestProject/Scripts/SampleScene.cs)
