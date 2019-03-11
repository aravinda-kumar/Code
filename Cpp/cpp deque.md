# cpp deque

- 双端队列
	- vector -- 连续空间
	- list -- 不连续空间
	- deque -- 段连续空间

- 特点
	- 插入/删除效率不高，但是比vector要好
	- 支持随机访问，但是比vector要慢
	- 支持头添加，支持尾添加
- 使用选择
	- 随机访问操作频率高，就算vector
	- 插入删除频率高，头尾添加，就选list
	- 随机访问+头添加使用deque
		- 支持随机访问，支持[]和at(),但是性能没有vector好
		- 可以在内部进行插入和删除操作，但性能不及list
- 函数对比
	- 对比vector
		- 没有容量和reserve()
		- 多了push_front和pop_front
		- 其他函数一样