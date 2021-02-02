# Unity1Week-VirusBuster
Unity1Week制作ゲーム、お題「ふえる」  
ゲームタイトル「VirusBuster」

## DEMO

![GifVirusBuster02](https://user-images.githubusercontent.com/62211872/90852131-a4186480-e3b1-11ea-819d-18f236d1f2be.gif)
![gifAnimation03](https://user-images.githubusercontent.com/62211872/90317015-5a6aec80-df61-11ea-9762-cdd2ba66893e.gif)  

Unity1WeekというUnityを使って1週間でゲームを作るオンラインイベントに参加した際に開発しました。  
ゲームURL：(https://unityroom.com/games/virusbuster-game)  
制作に関する記事：(https://machio-kinniku.hatenablog.com/entry/unity1week) 

## Application Concepts
### Design(設計)
コンセプトは「1週間で完成させることが可能で、なおかつリファクタリングや機能追加が容易なもの」としました。  
このコンセプトは上手く機能し、完成後もポーズ機能や音量調節機能の追加が容易な設計となりました。  

プログラム記述前に、大まかな処理の流れを書き出し、必要となるであろうスクリプトを整理しました。  
各ソースコードは可能な限りSOLID原則に基づき、役割によって細かく分け、後のリファクタリングが容易となる様に各場所にコメントを残してあります。  
なるべく負荷のかかる処理は最低限の実行とし、その他実行に使用する画像や音素材はデータ圧縮を施すことにより、実行環境でのロード時間を短縮しています。

### App(アプリ)
目標設定は「簡単で分かりやすく、雰囲気の良いもの」としました。  
その結果、総投稿数490のうち、雰囲気で29位,絵作りで47位でランクインしました。  

ゲームの説明をテキストではなく、ゲーム中のムービーに盛り込むことで、直観的に理解が容易いものとしました。  
雰囲気に関しては、使用する素材を十分な時間をかけて精査、あるいは作成することで、その作品の世界観を統一し、非常に高い雰囲気を保つことができました。

### Role(役割)
一人での個人開発によるもので、制作期間内でプログラムを記述する時間とゲーム内で使用する素材の作成時間の管理に努力しました。  

## Execution environment(実行環境)
各種Webブラウザ(IEを除く)  
次に記載するURLで実行(プレイ)できます：(https://unityroom.com/games/virusbuster-game)  

## Author
* 作成者：市川聖也(Seiya Ichikawa)
* 所属：未所属
* E-mail：seiya.ichikawa0628@gmail.com
* Twitter:@Machio_Kinniku
