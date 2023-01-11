# Kogane Json Firebase App Options

Firebase の AppOptions クラスを JSON 形式の文字列に変換できるパッケージ

## 使用例

```cs
using Firebase;
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Start()
    {
        var firebaseApp = FirebaseApp.DefaultInstance;
        var options     = firebaseApp.Options;

        Debug.Log( new JsonFirebaseAppOptions( options ) );
    }
}
```