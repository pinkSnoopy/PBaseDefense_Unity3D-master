using DesignPattern_Proxy;
using UnityEngine;

public class ProxyTest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        UnitTest();
    }

    // 
    void UnitTest()
    {

        // 產生Proxy
        Proxy theProxy = new Proxy();

        // 透過Proxy存取
        theProxy.Request();
        theProxy.ConnectRemote = true;
        theProxy.Request();
    }
}
