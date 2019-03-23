package myLinkedList;


public class MyLinkedList01 {
	//第一个节点和最后一个节点
	private Node first;
	private Node last;
	
	//节点个数
	private int size;
	
	public void add(Object obj) {
		Node node = new Node(obj);
		size++;
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
	}

	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		StringBuilder sb = new StringBuilder();
		sb.append('[');
		Node node = first;
		while(node.next != null) {
			sb.append(node.element + " ");
			node = node.next;
		}
		sb.setCharAt(sb.length()-1, ']');
		return sb.toString();
	}
	
	public static void main(String[] args) {
		MyLinkedList01 ls = new MyLinkedList01();
		for(int i=0;i<10;i++) {
			ls.add("zs"+i);
		}
		
		System.out.println(ls);
	}
}
