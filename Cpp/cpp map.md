# cpp map

- map -- 类似于字典
- map和multimap
	- map的键值是不允许重复的，multimap是允许重复的。

- 有序容器，添加的时候会排序，map的排序是按照键值排序

- 构造函数
	- map(); -- 无参构造 -- map\<int, char> m;
	- map(const _map& _Right) -- 拷贝构造
	- map(InputIterator _First, InputIterator _Last); -- 用另一段来构造

- 插入元素
	- pair \<iterator, bool> insert(const TYPE &val);
		- 返回类型是pair \<iterator, bool>, 根据bool的类型判断插入是否成功
		- 插入一个键值对
		- pair 系统提供的结构体，用来给map赋值
		- pair的两个元素是first和second;
	- iterator insert(iterator pos, const TYPE &val);
		- map的迭代器可以自加，但是不可以+1之类
		- pos没有太大的作用，仍然会自动排序
	- void insert(input_iterator start, input_iterator end);
		- end位置不复制
		- 提前插入数据也会和后续插入的混合一起排序
- 属性
	- 没有容量的概念
	- 得到元素的个数 -- size();
	- 得要一个元素在容器中的数量 -- count(const Key& _Key);
		- 实际上就是判断一个元素是否存在
	- 判断是否为空 -- empty();
- 输出
	- for_each
	- 循环
	- 迭代器 -- 指向pair的指针