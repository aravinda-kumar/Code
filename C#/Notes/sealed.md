# C#sealed用法
## 密封类
```cs
	class AA{}
	class BB:AA{}
	class CC:BB{}
	sealed class DD:CC{}
```
类DD不可以再次被继承
## 密封属性和密封方法
有时候不要将整个类进行密封，只需要对某些覆写的属性或者方法记性密封，以免被继续覆写
```cs
class AA
{
	public virtual string Name{get;set;}
	public virtual void Show(){}
}
class BB:AA
{
	public override string Name{get;set;}
	public override void Show(){}
}
class CC:BB
{
	public sealed override string Name{get;set;}
	public sealed override void Show(){}
}
class DD:CC{}
```
注：
1. 类DD虽然是从CC继承而来，但是它不可以继续对属性Name进行覆写
2. 在密封可覆写方法时，override和sealed要同时出现
3. 以上要求对于方法同样适用