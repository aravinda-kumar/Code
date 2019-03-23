package myLinkedList;


public class MyLinkedList01 {
	//��һ���ڵ�����һ���ڵ�
	private Node first;
	private Node last;
	
	//�ڵ����
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
			//����ǰ��ڵ�
			node.previous = last;
			
			//�����ڵ�����
			last.next = node;
			
			//��һ���ڵ���λ
			last = node;
			
			//���������־
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
