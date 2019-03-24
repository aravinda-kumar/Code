package zhushuai.collections;

import java.util.*;

/**
 * 测试表格的存储--ORM思想，表格对象映射
 */
public class TestStoreData {
    public static void main(String[] args){

        Map<String, Object> row1 = new HashMap<>();
        row1.put("ID", 1001);
        row1.put("姓名", "张三");
        row1.put("薪水", 20000);
        row1.put("入职日期", "2018-5-5");

        Map<String, Object> row2 = new HashMap<>();
        row2.put("ID", 1002);
        row2.put("姓名", "李四");
        row2.put("薪水", 30000);
        row2.put("入职日期", "2005-4-4");

        Map<String, Object> row3 = new HashMap<>();
        row3.put("ID", 1003);
        row3.put("姓名", "王五");
        row3.put("薪水", 3000);
        row3.put("入职日期", "2020-5-4");

        List<Map<String, Object>> table1 = new ArrayList<>();

        //添加输入
        table1.add(row1);
        table1.add(row2);
        table1.add(row3);

        //遍历列表输出数据
        for(Map<String, Object> item : table1){
            //现获取map的键对象的集合
            Set<String> keyset = item.keySet();
            //遍历set对象
            for(String keyvalue: keyset){
                System.out.print(keyvalue + ":" + item.get(keyvalue) + "\t");
            }
            System.out.println();
        }

    }
}
