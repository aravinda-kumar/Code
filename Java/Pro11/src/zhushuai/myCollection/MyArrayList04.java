package zhushuai.myCollection;

import javax.management.RuntimeErrorException;

/**
 * �Զ���ʵ��һ��arraylisy
 * ����set��get�������Լ��߽���
 * ����remove����
 * @author 11094
 * 
 */
public class MyArrayList04<E>{
	
	//Ԫ������
	private Object[] elementData;
	//Ԫ�صĸ���
	private int size;
	private final static int DEFAULT_CAPACITY = 10;
	
	//������
	public MyArrayList04() {
		//elementData = new Object[DEFAULT_CAPACITY];
		this(DEFAULT_CAPACITY);
	}
	
	public MyArrayList04(int capacity) {
		if(capacity < 0) {
			throw new RuntimeException("�������Ϸ�");
		}else if (capacity == 0) {
			elementData = new Object[DEFAULT_CAPACITY];
		}else {
			elementData = new Object[capacity];			
		}
	}
	
	//add����
	public void add(E obj) {
		//ʲôʱ������
		if (size == elementData.length - 1) {
			//�Ӻŵ����ȼ�������Ϊ�����
			Object[] newArray = new Object[elementData.length + (elementData.length >> 1)];	 //��������ԭ�����鳤�ȵ�1.5��
			System.arraycopy(elementData, 0, newArray, 0, elementData.length);
			
			//ָ���µ�����ĵ�ַ��ʵ������
			elementData = newArray;
		}
		//�������Ԫ��
		elementData[size++] = obj;
	}
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		StringBuilder sb = new StringBuilder();
		sb.append("[");
		for(int i=0;i<size;i++) {
			sb.append(elementData[i] + " ");
		}
		//����β�ÿո��滻Ϊ������
		sb.setCharAt(sb.length()-1, ']');
		return sb.toString();
	}
	
	public E get(int index) {
		checkRange(index);
		return (E)elementData[index];
	}
	
	public void set(int index, E element) {
		//�߽���
		checkRange(index);
		elementData[index] = element;
	}
	
	private void checkRange(int index) {
		if(index <0 || index >= size) {
			//����Խ��
			throw new IndexOutOfBoundsException("����Խ��:" + index);
		}
	}
	
	public void remove(E element) {
		//element������Ԫ�ذ����Ƚϣ���õ�һ���Ƚ�Ϊtrue�ķ���
		for(int i=0;i<size;i++) {
			if(element.equals(elementData[i])) {
				//����Ԫ�شӴ˴��Ƴ�
				remove(i);
				break; //break����ֻɾ����һ��
			}
		}
	}
	
	public void remove(int index) {
		checkRange(index);
		// ѭ������
		int numMoved = size-index-1;
		if(numMoved>0) {
			System.arraycopy(elementData, index+1, elementData, index, numMoved);			
		}
		//����һ��������λ��Ԫ����null;
		set(size-1, null);
		size--;
	}
	
	public int size() {
		return size;
	}
	
	public boolean isEmpty() {
		return size == 0;
	}
	
	public static void main(String[] args) {
		MyArrayList04<String> mal = new MyArrayList04<String>(20);
		for(int i=0;i<40;i++) {
			mal.add("zs"+i);
		}
		
		System.out.println(mal);
		
		System.out.println(mal.get(39));
		
		mal.set(39, "zhushuai");
		System.out.println(mal);
		
		mal.remove(3);
		System.out.println(mal);
		mal.remove("zhushuai");
		System.out.println(mal);
		System.out.println(mal.size());
		System.out.println(mal.isEmpty());
	}
}
