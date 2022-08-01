using DesignPattern_Adapter;
using UnityEngine;

public class AdapterTest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        UnitTest();
    }

    // 
    void UnitTest()
    {
        Target theTarget = new Adapter();
        theTarget.Request();
    }
}
