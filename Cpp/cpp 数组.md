# cpp 数组

- vector
	- 向量(动态数组)
		- 内存分配的原则和string类似
		- 是连续的空间，空间不够用的时候，会申请一个更大的连续的空间，同时迭代器失效。
	- 头文件 -- vector
	- vector是泛型，需要传入参数列表
	- 容器的名字 -- 类名
	- 参数列表
		- 容器的数据的类型
		- 类型种类
			- 基本数据类型
			- 结构体
			- 指针
			- 对象
				- 普通的类对象
				- 其他的容器的对象
	- 构造函数
		- vector(); -- 无参构造函数
		- vector(size_type _Count); -- 初始化5个元素，默认是0
		- vector(size_type num, const TYPE &val); -- 用num个val初始化
		- vector(const vector &from); -- 拷贝构造，用另一个vector进行初始化，深拷贝
		- vector(input_iterator start, input_iterator end); -- 用迭代器进行初始化
	- 迭代器的定义
		- vector\<int\>::iterator ite; -- 要包含参数列表，且要和指向的vector的参数列表一直
	- 容量
		- capacity() -- 初始化几个个数，容量就是几个
			- 容量不够的时候，每次增加前一次容量的一半
		- reverse()
			- 修改容量，分配多大就是多大
			- 只能变大，不能变小
		- 重新申请空间之后迭代器失效
	- size() -- 元素的个数
	- resize() -- 重新设置元素个数
		- 小于容量，容量个数不变
		- 大于容量，容量个数扩展，还是按照前次容量的一半增加
	- empty() -- 判断容器内是否有元素
	- 操作
		- 输出
			- 输出单个
				- 用下标运算符[]或者使用at();
				- back()返回尾巴的元素;
			- 输出整个元素
				- 整个输出，普通for循环用at()或者下标运算
				- for_each
				- c++11标准中可以使用范围for, for(type value in object);
		- 增加
			- 尾添加
				- void push_back(const TYPE &val);
			- 中间添加
				- iterator insert(iterator loc, const TYPE &val); -- 在迭代器的位置添加值
				- void insert(iterator loc, size_type num, const TYPE &val); -- 在迭代器位置添加num个va1;
				- void insert(iterator loc, input_iterator start, input_iterator end); -- 在loc位置添加另一个容器中的一段值，不包含end指向的位置的元素。
			- 由于是数组，不考虑重新增加空间的话，尾添加的效率非常高。中间添加的效率很低。
		- 删除
			- 尾删除
				- void pop_back();
			- 删除指定元素
				- iterator erase(iterator loc); -- 删除指定位置的元素
				- iterator erase(iterator start, iterator end); -- 删除一段，不包含end位置哪一个
			- 删除所有
				- void clear(); -- 容量不变，个数消除
			- 交换内容
				-   void swap(vector &from);
		- 改变 -- 利用迭代器，下标运算等等方法。
			- 利用迭代器函数赋值
				- void assign(input_iterator start, input_iterator end);
				- void assign(size_type num, const TYPE &val);
	- 运算符重载
		- >, <, ==等，原则和string一致
	- 几个算法
		- 遍历
		```cpp
			template<class InputIterator, class Function>
			Function for_each(InputIterator _First,  InputIterator _Last, Function _Func);
			//参数三有误返回值都行，_Func()的参数是vector的元素的类型
			//用法和string中的一样
		```
		- 排序
		```cpp
			template<class RandomAccessIterator>
			void sort(RandomAccessIterator _First, RandomAccessIterator _Last);
			//默认从小排到大
			template<class RandomAccessIterator, class Pr>
			void sort(RandomAccessIterator _First, RandomAccessIterator _Last, BinaryPredicate _Comp);
			//参数三 greater<>()可以指定从大到小
			//这两个函数的用法也痛string
		```
		- 乱序
		```cpp
			void random_shuffle(RandomAccessIterator _First, RandomAccessIterator _Last);
		```
- array
	- 数组(固定数组)
- valarray
	- 属于数学计算的一个