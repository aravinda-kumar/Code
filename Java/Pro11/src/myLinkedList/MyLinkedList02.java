package myLinkedList;


public class MyLinkedList02 {
	//第一个节点和最后一个节点
	private Node first;
	private Node last;
	
	//节点个数
	private int size;
	
	public void add(Object obj) {
		Node node = new Node(obj);
		
		if(first == null) {
//			node.previous = null;
//			node.next = null;
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
		System.out.println(size);
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
	
	public static void main(String[] args) {
		MyLinkedList02 ls = new MyLinkedList02();
		for(int i=0;i<10;i++) {
			ls.add("zs"+i);
		}
		
		System.out.println(ls);
		System.out.println(ls.get(6));
	}
}
