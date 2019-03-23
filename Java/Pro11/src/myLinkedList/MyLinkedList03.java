package myLinkedList;
/**
 * ����
 * ����ɾ������
 * @author zhushuai
 *
 */

public class MyLinkedList03 {
	//��һ���ڵ�����һ���ڵ�
	private Node first;
	private Node last;
	
	//�ڵ����
	private int size;
	
	public void add(Object obj) {
		Node node = new Node(obj);
		
		if(first == null) {
			node.previous = null;
			node.next = null;
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
	
	//��������ɾ��
	public void remove(int index) {
		//�����߽���
		if(index<0 || index >= size) {
			throw new IndexOutOfBoundsException("����Խ�磺" + size);
		}
		if(index == 0) {
			//Ŀ��ڵ���ͷ�ڵ�
			first = first.next;
			first.previous = null;
			size--;
			return;
		}
		if(index == size-1) {
			//Ŀ��ڵ���β�ڵ�
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
		//Ŀ��ڵ��ҵ�֮��
		temp.previous.next = temp.next;
		temp.next.previous = temp.previous;	
		size--;
	}
	
	//����Ԫ��ɾ��
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
			throw new IndexOutOfBoundsException("Ԫ�ز�����");
		}
	}
	public static void main(String[] args) {
		MyLinkedList03 ls = new MyLinkedList03();
		for(int i=0;i<10;i++) {
			ls.add("zs"+i);
		}
		
		System.out.println(ls);
		System.out.println(ls.get(6));
		ls.remove(2);
		System.out.println(ls);
		ls.remove(8);
		System.out.println(ls);
		ls.remove(0);
		System.out.println(ls);
		ls.remove("zs4");
		System.out.println(ls);
	}
}
