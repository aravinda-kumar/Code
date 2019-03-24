package zhushuai.collections;

import java.util.*;

/**
 * 测试表格的存储--ORM思想，表格对象映射
 * 每一行数据使用javabean
 * 所谓的javabean就是一个包含数据的类
 * 多行数据存入map或者list中
 */
public class TestStoreData2 {
    public static void main(String[] args){
        User user1 = new User(1001, "张三", 20000, "2018-5-5");
        User user2 = new User(1002, "李四", 30000, "2005-4-4");
        User user3 = new User(1003, "王五", 3000, "2020-5-4");

        //使用map存放
        Map<User, Object> table = new HashMap<>();
        table.put(user1, null);
        table.put(user2, null);
        table.put(user3, null);

        //使用迭代器遍历map -- 现获取set
        Set<Map.Entry<User, Object>> item = table.entrySet();

        //打印表头
        System.out.println("ID" + "\t\t" + "Name" + "\t" + "Salary" + "\t" + "Date");

        //遍历map
        for(Iterator<Map.Entry<User, Object>> obj = item.iterator(); obj.hasNext();){
            Map.Entry<User, Object> sig = obj.next();
            User user = sig.getKey();
            System.out.println(user.getId() + "\t" + user.getName() + "\t\t" + user.getSalary() + "\t" + user.getHiredate());
        }
    }
}

class User{
    private int id;
    private String name;
    private double salary;
    private String hiredate;

    //一个完整的javabean要有完整的get/set对象和一个无参的构造器
    public User(){
        super();
    }

    public User(int id, String name, double salary, String hiredate) {
        this.id = id;
        this.name = name;
        this.salary = salary;
        this.hiredate = hiredate;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public double getSalary() {
        return salary;
    }

    public void setSalary(double salary) {
        this.salary = salary;
    }

    public String getHiredate() {
        return hiredate;
    }

    public void setHiredate(String hiredate) {
        this.hiredate = hiredate;
    }
}