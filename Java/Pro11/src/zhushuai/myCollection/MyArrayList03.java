package zhushuai.myCollection;

/**
 * �Զ���ʵ��һ��arraylisy
 * @author 11094
 * 
 */
public class MyArrayList03<E>{
	
	//Ԫ������
	private Object[] elementData;
	//Ԫ�صĸ���
	private int size;
	private final static int DEFAULT_CAPACITY = 10;
	
	//������
	public MyArrayList03() {
		//elementData = new Object[DEFAULT_CAPACITY];
		this(DEFAULT_CAPACITY);
	}
	
	public MyArrayList03(int capacity) {
		elementData = new Object[capacity];
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
		//��������Ԫ��
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
	
	public static void main(String[] args) {
		MyArrayList03<String> mal = new MyArrayList03<String>(20);
		for(int i=0;i<40;i++) {
			mal.add("zs"+i);
		}

		System.out.println(mal);
	}
}