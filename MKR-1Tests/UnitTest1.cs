using CrossplatformMKR_1;

namespace MKR_1Tests;

[TestFixture]
public class FirstTaskTest
{

    private Random _random;
    private int N;
    private int[] M;
    
    [SetUp]
    public void SetUp()
    {
        _random = new Random();
        
        N = _random.Next(1, 1000);
        M = new int[N];

        for (var i = 0; i < N; i++)
        {
            M[i] = _random.Next(1, 1000);
        }
    }
    
    [Test]
    public void TestRandomValuesNoException()
    {
        var firstTask = new MKRTask(N, M);
        firstTask.Calculate();
    }
    
    [Test]
    public void TestDefaultValue()
    {
        var firstTask = new MKRTask(3, [100, 100, 100]);
        var result = firstTask.Calculate();
        
        Assert.IsTrue(result == 1000000, "");
    }
    
    [Test]
    public void TestDefaultValue2()
    {
        var firstTask = new MKRTask(4, [2, 1, 1, 1]);
        var result = firstTask.Calculate();
        
        Assert.IsTrue(result == 7, "");
    }

    
    [Test]
    public void TestDefaultValue3()
    {
        var firstTask = new MKRTask(5, [2, 2, 2, 2, 2]);
        var result = firstTask.Calculate();
        
        Assert.IsTrue(result == 80, "");
    }
    
    [Test]
    public void TestDefaultValue4()
    {
        var firstTask = new MKRTask(3, [1, 2, 3]);
        var result = firstTask.Calculate();
        
        Assert.IsTrue(result == 6, "");
    }
    
    [Test]
    public void TestDefaultValue5()
    {
        var firstTask = new MKRTask(6, [5, 1, 3, 2, 4, 6]);
        var result = firstTask.Calculate();
        
        Assert.IsTrue(result == 735, "");
    }
    
    [Test]
    public void TestNValueValidation()
    {
        Assert.Throws<ArgumentException>(code: () => new MKRTask(0, []));
    }
    
    [Test]
    public void TestMValueValidation()
    {
        Assert.Throws<ArgumentException>(code: () => new MKRTask(4, [100, 3213, 3244, 4144, 444]));
    }
}