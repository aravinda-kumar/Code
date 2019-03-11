# cpp string

- string
- 专门的字符串处理的一个类
- 跟char*的区别
	- char*就是指向字符串数组地址的指针
	- string是一个类，这个类将以上的内容封装到一起，使得字符串的操作更加灵活，方式更多，管理更合理
	- string这个类，我们使用的时候不用考虑内存的分配和释放，不用担心越界崩溃，因为在封装string这个类的时候，已经考虑到了几乎所有的情况，并做了处理
- 头文件 -- string
- 定义
	- 构造函数
		- string(); -- 不传初始值得string默认赋值'\0'
			- c_str() 返回当前字符串首字符的地址 const char*
		- string(size_t length, char ch) -- 初始化为length个ch
		- string(const char *str);
		- string(const char *str, size_type length); -- str的前length个
		- string(const char *str, size_t index, size_type length); -- 从index(从0开始计数)开始复制length个
		- 拷贝构造
			- String(const String& str); -- 深拷贝
	- 运算符重载 -- 声明为友元函数
- 属性
	- 容量
		- capacity()
			- 默认容量大小(vs)，少于15个，申请15个，以后每次超过范围后增加16个字节空间
			- vc6.0第一次申请31个，后续每次申请32个
		- reserve()
			- 修改容量，不能变大，只能变小，在字符长度后面加上设置的大小对16的取整乘以16
			- 调用它之后，容量变成了默认长度加在字符长度后面加上设置的大小对16的取整乘以16
	- 长度 -- length();
		- 空字符串的长度是0;
	- 字符的个数 -- size();
	- 重新设置字符个数 -- resize()
		- 小于容量，容量个数不变
		- 大于容量，容量个数扩展，reserve的规律增长
		- 对字符串按照既定长度进行截断
- 输出
	- 输出整个	-- cout << string; 或 cout << str.c_str();
	- 输出单个字符 -- str[i]; 或者 str.at(); -- .at()越界会抛出out_of_range的类的异常
		- 索引不可以越界
- 修改
	- 修改指定元素
		- 下标运算[]
		- at()
	- 中间插入
		- basic_string &insert(size_type index, const basic_string &str);
			- index位置插入str
		- basic_string &insert(size_type index, const char* str);
			- index位置插入一个字符串
		- basic_string &insert(size_type index1,const basic_string &str, size_type index2, size_type num);
			- 在index1的位置插入
		- basic_string &insert(size_type index, const char* str, size_type num);
			- 插入前几个
		- basic_string &insert(size_type index, size_type num, char ch);
			- 在index为插入num个ch
	- 尾巴插入
		-  append();
			- 参数类型同上
	- 重新赋值
		- =
		- >>
		- assign
			- 参数类型同上
- 操作函数
	- 比较
		- 相等返回0，大于返回1，小于返回-1
		- > < ==等
		- compare();
	- 复制
		- copy(); -- 是将字符串的内容复制到一个字符数组中
	- 查找子串
		- find()
	- 返回子串
		- substr(位置，长度);
	- 交换
		- swap(string& str) 和str中的内容进行交换
	- 运算符重载
		- + 运算符：类似于拼接字符串
- 迭代器
	- 定义一个string的迭代器string::iterator ite;
	- 理解
		- 相当于定义了一个指向string对象元素的指针，本质相当于一个char*指针
		- 定义之后就跟指针的用法是一样的
	- 通过迭代器遍历string元素
		- for (ite = str.begin(); ite != str.end(); ite++);
		- begin和end都返回迭代器
		- begin是第一个位置，end是最后一个字符的后一个位置
	- 使用迭代器的理由
		- 迭代器要跟算法进行结合，它适用于所有的容器，即一个通用类型的指针，或者类似智能指针。
	- 迭代器失效
		- string 容量不够重新申请空间的时候，迭代器就会失效的
		- 使用迭代器的时候要注意迭代器的指向
- string成员函数及涉及到的迭代器
	- iterator begin() -- 函数返回一个迭代器，指向字符串的第一个元素
	- iterator end() -- 函数返回一个迭代器，指向字符串的末尾元素(最后一个字符的后一个元素)
	- append(input_iterator start, input_iterator end);
	- 删除
		- iterator erase(iterator pos);	-- pos迭代器指的位置
		- iterator erase(iterator start, iterator end);
	- 插入
		- void insert(iterator i, size_type num, const char &ch);
			- 在位置i处插入几个ch，不替换
		- void insert(inerator i, iterator start, iterator end);
			- 在位置i插入一整个字符串以start开始，end结束，不替换
- 算法
	- 迭代器，用在与算法结合的时候才能体现真正的价值
	- 头文件algorithm
	- 遍历
	```cpp
	template<class InputIterator, class Function>
	Function for_each(InputIterator _First, InputIteartor _Last, Function _Func);
	//参数三有无返回值都行，参数是该容器指向的元素的类型
	```
	- 排序
	```cpp
	//第一种
	template<class RandomAccessIterator>
	void sort(RandomAccessIterator _First, RandomAccessIterator _Last);
	//从小到大
	//第一种
	template<class RandomAccessIterator, class Pr>
	void sort(RandomAccessIterator _First, RandomAccessIterator _Last, BinaryPredicate _Comp);
	//参数三greater<>()可以指定从大到小，要加()
	//头文件functional
	```