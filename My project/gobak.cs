#10강 
using System.ComponentModel.DataAnnotations;

public class Calculator
{
    public int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }
    public void Multiple(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"{num1} x {num2} = {result}");
    }
}

private void Awake()
{
    Multiple(3, 4);
    Multiple(5, 8);
    Multiple(4, 6);
}
public void Multiple(int num1, int num2)
{
    int result = num1 * num2;
    Debug.Log($"{num1} x {num2} = {result}");
#return ex
private void Awake()
{
    int a = Max(10, 20);
    Debug.Log(Max(100, 200));
    Max(5, 10);
}
public int Max(int num1, int num2)
{
    if (num1.num2)
    {
        return num1;
    }
    return num2;
}
#값에 의한 전다 ex
private void Awake()
{
    int a = 3, b = 4;
    Debug.Log($"Before a = {a}. b = {b}");
    Swap(a, b);
    Debug.Log($"After a ={a}, b={b}");
}
public void Swap(int num1, int num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}
#참조에 의한 전달 ex
private void Awake()
{
    int a = 3, b = 4;
    Debug.Log($"a={a}, b={b}");
    Swap(ref a, ref b);
    Debug.Log($"a ={a}, b={b}");
}
public void Swap(ref int num1, ref int num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}
#출력 전용 매개 변수 
priate void Awake()
{
    int a=5, b = 4, result1 = 0, result2 = 0;
Divide(a, b, ref result1, ref result2);
Debug.Log($"몫 = {result1}, 나머지 = {result2}");
}
public void Divide(int num1, int num2, ref int result1, ref int result2)
{
    result1 = num1 / num2
    result2 = num1 % num2;
}
#가변길이 매개변수
public void Sum(params int[] nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Length; ++i)
    {
        sum += nums[i];
    }
    Debug.Log($"합계 : {sum}");
}

#11강 
public class Player
{
    private string ID = "고박사";
    private int currentHP = 1000;

    publid void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damgde;
        }
    }
}
public class Enemy
{
    private Player player;

    public void AttackToTarget(player target)
    {
        target.TakeDamage(100);
    }
}
#클래스 객체 생성
public class GameController : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player 01 = new Player();
        player01.TakeDamage(100);
        player02.TakeDamage(200);
    }
}
#생성자
public class Player
{
    private string ID
    private int currentHP

    public Player()
    {
        ID = "고박사";
        currentHP = 1000;
    }
}
public class GameController : MonoBehaviour
{
    public Player player01;

    private void Awake()
    {
        player01 = new Player();
    }
}
#생성자 메소드 오버로딩 
public class Player
{
    private string ID
    private int currentHP

    public Player()
    {
        ID = "고박사";
        currentHP = 1000;
    }

    public Player(string id, int hp)
    {
        ID = id;
        currentHP = hp;
    }
}
public class GameController : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player();
        player02 = new Player("유니티", 10);
    }
}
#얕은 복사
public class GameController : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player("고박사", 1000);
        player02 = player01
        player02.ID = "유니티";

        Debug.Log($"ID : {player01.ID}");
        Debug.Log($"ID : {player02.ID}");
    }
}
#깊은 복사
public class GameController : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player("고박사", 1000);

        player02 = player01.DeepCopy();
        player02.ID = "유니티";

        Debug.Log($"ID : {player01.ID}");
        Debug.Log($"ID : {player02.ID}");
    }
}
public class Player
{
    public string ID;
    private int currentHP;

    public Player Deepcopy()
    {
        player clone = new Player();
        clone.ID = ID;
        clone.currentHP = currentHP;

        return clone;
    }
}
#this 키워드
public class Player
{
    public string ID = "고초아";

    public SetID(srting ID)
    {
        Debug.Log($"ID : {ID}");
        Debug.Log($"ID : {this.ID}');
    }
}

public class CameController
{
    private void Awake()
    {
        player01.SetID("유니티");
    }
}
#this() 생성자
public class Player
{
    private string ID;
    private int currentHP;
    private int currentMP;

    public Player()
    {
        ID = "고박사";
    }
    public Player(int hp) : this()
    {
        currentHP = hp;
    }
}
#12강
public class Emtity
{
    public steing ID;
    protected int currentHP;
}
public class player : Entity
{
    private string ID;
    public Player(string id, int hp)
    {
        bass.ID = "Noname";
        ID = id;
        currentHP = hp;
    }
}
public class Emtity
{
    public void Attack()
    {
        Debug.Log("적을 공격!");
    }
    public void Heal()
    {
        Debug.Log("체력을 회복!");
    }
}
public class Goblin : Entity
{
    public void Avoid()
    {
        Debug.Log("도망가자!");
    }
    public void Heal()
    {
        Debug.Log("고블린이 회복!");
    }
}