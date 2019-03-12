# cpp map

- map -- 类似于字典
- map和multimap
	- map的键值是不允许重复的，multimap是允许重复的。

- 有序容器，添加的时候会排序，map的排序是按照键值排序

- 构造函数
	- map(); -- 无参构造 -- map\<int, char> m;
	- map(const _map& _Right) -- 拷贝构造
	- map(InputIterator _First, InputIterator _Last); -- 用另一段来构造

- 属性
	- 没有容量的概念
	- 得到元素的个数 -- size();
	- 得要一个元素在容器中的数量 -- count(const Key& _Key);
		- 实际上就是判断一个元素是否存在
	- 判断是否为空 -- empty();

- 操作
	- 增加
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
	- 修改
		- 键值不可以修改，实值才可以修改，键值如果允许修改，修改之后整个结构会发生改变。
	- 查看
		- 输出
			- for_each
			- 循环
			- 迭代器 -- 指向pair的指针
	- 删除
		- erase()
			- iterator erase(iterator _Where); -- 删除迭代器的位置的元素
			- iterator erase(iterator _First, iterator _Last); -- 删除一段值
			- size_type erase(const key_type& _Key); -- 通过键值删除元素
		- clear() -- 清空所有元素

- 其他函数
	- 查找
		- iterator find(const Key& _Key); -- 通过键值查找，返回一个迭代器 ,没找到则无法输出，崩溃, 准确位置是end()
	- 交换
		- swap(); -- 两个map相互交换
	- 默认排序
		- 从小打到
		- 从大到小 -- greater<int> -- 后面不加圆括号 --map<int, char, greater<int>> mp;
	- iterator lower_bound(key) -- 返回参数key位置，该位置的键值不小于key : key小于等于pos
	- iterator upper_bound(key) -- 返回位置，该位置的键值>key  : key小于pos
	- pair<iterator, iterator> equal_range(key) -- 返回这个区间

- multimap
	- 操作函数跟map都一样
	- 头文件 map
	- 区别
		- 允许键值重复
		- 计数 -- count()
		- find函数返回第一个匹配的元素，没找到则返回最后一个