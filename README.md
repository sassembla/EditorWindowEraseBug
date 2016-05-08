#Editor window missing bug.

## 発生環境

Unity 5.3.4P4 ~ 6  
Mac OS X 10.11.4


## 再現手順

1. UnityでProjectを起動
2. Window > SampleEditWindow でウィンドウを開く
3. Assets/Something.csのコメントを外してわざとコンパイルエラーを出す
4. Unity Editorでのコンパイルに失敗、SampleEditWindowが閉じる(この時点で過去の5.3.4P1などと挙動が異なる。)
5. コンパイルエラーが消えるように、Assets/Something.csのエラー箇所を再度コメントして保存
6. コンパイル成功
7. が、Window > SampleEditWindow でウィンドウが開かない。
8. Window > Layouts > Revert Factory Settings... を実行すると、下記エラーが出た後、SampleEditWindowが開くようになる。

```8で出るエラー
Failed to destroy editor windows: #1
SampleEditWindow
UnityEditor.WindowLayout:LoadWindowLayout(String, Boolean)
```

## 以前と異なる挙動
手順4で、コンパイルエラーにつられてエディタウィンドウが消えるのが変。

## 問題が発生しないバージョン
Unity 5.4b17
Unity 5.3.4p3

