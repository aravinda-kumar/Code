package zhushuai.myCollection;

/**
 * 模拟实现jdk中提供的ArrayList类
 * @author SHUNCS
 *
 */
public class MyArrayList {
	/**
     * The value is used for object storage.
     */
    private Object[] value;

    /**
     * The size is the number of objects used.
     */
    private int size = 0;
    
    public MyArrayList() {
    	this(16);
    }
    
    public MyArrayList(int size) {
    	if(size < 0) {
    		throw new OutOfMemoryError();
    	}
    	value = new Object[size];
    }
    
    public void add(Object obj) {
    	value[size] = obj;
    	size++;
    	if(size>=value.length) {
    		//复合这个条件，需要扩容
    		int newCapacity = value.length * 2 + 2;
    		Object[] newlist = new Object[newCapacity];
    		for(int i=0;i<value.length;i++) {
    			newlist[i] = value[i];
    		}
    		value = newlist;
    	}
    }
    
    public Object get(int index) {
    	if(index<0 || index >= size) {
    		throw new IndexOutOfBoundsException();
    	}
    	return value[index];
    }
    
    int getSize() {
    	return size;
    }
    
    public static void main(String[] args) {
		MyArrayList list = new MyArrayList(2);
		list.add("aaa");
		list.add(new Human("cde"));
		list.add("123");

		System.out.println(list.get(2));
		Human h = (Human)list.get(1);
		System.out.println(h.name);
		
		System.out.println(list.getSize());
	}
}
