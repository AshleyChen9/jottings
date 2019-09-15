using UnityEngine;
using System.Collections;

namespace DesignPattern_Strategy
{
    // 擁有Strategy物件的客戶端
    public class Context
    {
        Strategy m_Strategy = null;

        // 設定演算法
        public void SetStrategy(Strategy theStrategy)
        {
            m_Strategy = theStrategy;
        }
        // 執行目前的演算法
        public void ContextInterface()
        {
            m_Strategy.AlgorithmInterface();
        }
    }

    // 演算法的共用介面, Context透過此介面呼叫 ConcreteStrategy所實作的演算法
    public abstract class Strategy // 定义一个抽象类，“abstract”->接口
    {
        public abstract void AlgorithmInterface();
    }
    
    // 演算法A
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface() //“继承性”，子类继承父类函数，并override重写父类
        {
            Debug.Log("ConcreteStrategyA.AlgorithmInterface");
        }
    }

    // 演算法B
    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("ConcreteStrategyB.AlgorithmInterface");
        }
    }

    // 演算法C
    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("ConcreteStrategyC.AlgorithmInterface");
        }
    }
}

using UnityEngine;
using System.Collections;
using DesignPattern_Strategy;

public class StrategyTest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        UnitTest();
    }

    // Update is called once per frame
    void UnitTest()
    {
        Context theContext = new Context();

        // 設定演算法
        theContext.SetStrategy(new ConcreteStrategyA());  //调用子类A的函数，实现A的效果
        theContext.ContextInterface();

        theContext.SetStrategy(new ConcreteStrategyB());  //调用子类B的函数，实现B的效果
        theContext.ContextInterface();

        theContext.SetStrategy(new ConcreteStrategyC());  //调用子类C的函数，实现C的效果
        theContext.ContextInterface();
    }
}