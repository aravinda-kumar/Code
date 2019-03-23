package myLinkedList;


public class MyLinkedList02 {
	//��һ���ڵ�����һ���ڵ�
	private Node first;
	private Node last;
	
	//�ڵ����
	private int size;
	
	public void add(Object obj) {
		Node node = new Node(obj);
		
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
		size++;
		System.out.println(size);
	}
	
	public Object get(int index) {
		//�����߽���
		if(index<0 || index >= size) {
			throw new IndexOutOfBoundsException("����Խ�磺" + size);
		}
		//��ǰ�����ң�ָ��λ��ָ���һ����ʼ
		Node temp = first;
		if(index <= (size >> 1)) {
			for(int i=0;i<index;i++) {
				temp = temp.next;
			}			
		}else {
			//�Ӻ���ǰ���ң�ָ��λ��ָ�����һ����ʼ
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
