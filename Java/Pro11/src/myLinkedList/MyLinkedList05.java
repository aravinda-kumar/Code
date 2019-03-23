package myLinkedList;

import org.w3c.dom.ls.LSException;

/**
 * ����
 * ����ɾ������
 * ���Ӳ���ڵ�
 * ��ӷ���
 * @author zhushuai
 *
 */

public class MyLinkedList05<E> {
	//��һ���ڵ�����һ���ڵ�
	private Node first;
	private Node last;
	
	//�ڵ����
	private int size;
	
	public void add(E obj) {
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
	
	private void checkRange(int index) {
		//�����߽���
		if(index<0 || index >= size) {
			throw new IndexOutOfBoundsException("����Խ�磺" + size);
		}
	}
	
	private Node getNode(int index) {
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
		return temp;
	}
	
	public E get(int index) {
		checkRange(index);
		return (E)getNode(index).element;
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
		checkRange(index);
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
		temp = getNode(index);
		//Ŀ��ڵ��ҵ�֮��
		temp.previous.next = temp.next;
		temp.next.previous = temp.previous;	
		size--;
	}
	
	//����Ԫ��ɾ��
	public void remove(E obj) {
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
	
	public void insert(int index, E obj) {
		Node node = new Node(obj);
		if(index == 0) {
			//�����׽ڵ�
			node.next = first;
			first.previous = node;
			first = node;
			first.previous = null;
			size++;
			return;
		}
		if(index == size-1) {
			//����β�ڵ�
			last.next = node;
			node.previous = last;
			last = node;
			last.next = null;
			size++;
			return;
		}
		Node temp = getNode(index);
		node.next = temp.next;
		temp.next = node;
		
		node.next.previous = node;
		node.previous = temp;
	}

	public static void main(String[] args) {
		MyLinkedList05<String> ls = new MyLinkedList05<String>();
		for(int i=0;i<10;i++) {
			ls.add("zs"+i);
		}

		System.out.println(ls);
		
		System.out.println(ls.get(1));
		
		ls.insert(0, "abc");
		System.out.println(ls);
		ls.insert(6, "abc");
		System.out.println(ls);
		ls.insert(4, "abc");
		System.out.println(ls);
	}
}
