package myLinkedList;

import org.w3c.dom.ls.LSException;

/**
 * 链表
 * 增加删除功能
 * 增加插入节点
 * @author zhushuai
 *
 */

public class MyLinkedList04 {
	//第一个节点和最后一个节点
	private Node first;
	private Node last;
	
	//节点个数
	private int size;
	
	public void add(Object obj) {
		Node node = new Node(obj);
		
		if(first == null) {
			node.previous = null;
			node.next = null;
			first = node;
			last = node;
		}else {
			//连接前向节点
			node.previous = last;
			
			//两个节点相连
			last.next = node;
			
			//后一个节点移位
			last = node;
			
			//定义结束标志
			last.next = null;
		}
		size++;
	}
	
	public Object get(int index) {
		//索引边界检查
		if(index<0 || index >= size) {
			throw new IndexOutOfBoundsException("索引越界：" + size);
		}
		//从前向后查找，指针位置指向第一个开始
		Node temp = first;
		if(index <= (size >> 1)) {
			for(int i=0;i<index;i++) {
				temp = temp.next;
			}			
		}else {
			//从后向前查找，指针位置指向最后一个开始
			temp = last;
			for(int i=size-1;i>index;i--) {
				temp = temp.previous;
			}	
		}
		return temp.element;
	}
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		StringBuilder sb = new StringBuilder();
		sb.append('[');
		Node node = first;
		while(node != null) {
			sb.append(node.element + " ");
			node = node.next;
		}
		sb.setCharAt(sb.length()-1, ']');
		return sb.toString();
	}
	
	//根据索引删除
	public void remove(int index) {
		//索引边界检查
		if(index<0 || index >= size) {
			throw new IndexOutOfBoundsException("索引越界：" + size);
		}
		if(index == 0) {
			//目标节点是头节点
			first = first.next;
			first.previous = null;
			size--;
			return;
		}
		if(index == size-1) {
			//目标节点是尾节点
			last = last.previous;
			last.next = null;
			size--;
			return;
		}
		Node temp = null;
		if(index < (size >>1)) {
			temp = first;
			for(int i=0;i< index;i++) {
				temp = temp.next;
			}
		}else {
			temp = last;
			for(int i=size-1;i>index;i--) {
				temp = temp.previous;
			}
		}
		//目标节点找到之后
		temp.previous.next = temp.next;
		temp.next.previous = temp.previous;	
		size--;
	}
	
	//根据元素删除
	public void remove(Object obj) {
		Node temp = first;
		int i;
		for(i=0; temp!=null;i++) {
			if(obj.equals(temp.element)) {
				remove(i);
				break;
			}
			temp = temp.next;
		}
		if(i == size) {
			throw new IndexOutOfBoundsException("元素不存在");
		}
	}
	
	public void insert(int index, Object obj) {
		Node node = new Node(obj);
		if(index == 0) {
			//增加首节点
			node.next = first;
			first.previous = node;
			first = node;
			first.previous = null;
			size++;
			return;
		}
		if(index == size-1) {
			//增阿基尾节点
			last.next = node;
			node.previous = last;
			last = node;
			last.next = null;
			size++;
			return;
		}
		Node temp = first;
		for(int i=0;i<index;i++) {
			temp = temp.next;
		}
		node.next = temp.next;
		temp.next = node;
		
		node.next.previous = node;
		node.previous = temp;
	}

	public static void main(String[] args) {
		MyLinkedList04 ls = new MyLinkedList04();
		for(int i=0;i<10;i++) {
			ls.add("zs"+i);
		}
		
		System.out.println(ls);
		
		ls.insert(0, "abc");
		System.out.println(ls);
		ls.insert(6, "abc");
		System.out.println(ls);
		ls.insert(4, "abc");
		System.out.println(ls);
	}
}
