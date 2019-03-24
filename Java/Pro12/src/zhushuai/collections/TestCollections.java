package zhushuai.collections;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

/**
 * collections辅助类的使用
 */
public class TestCollections {
    public static void main(String[] agrgs){
        List<String> list = new ArrayList<String>();
        for(int i=0;i<10;i++){
            list.add("zs" + i);
        }
        System.out.println(list);

        //随机排布list中的元素
        Collections.shuffle(list);
        System.out.println(list);

        //逆序排序
        Collections.reverse(list);
        System.out.println(list);

        //正向排序 -- 递增的方式排序
        //自定义的类需要实现comparable接口
        Collections.sort(list);
        System.out.println(list);

        //二分法查找, 元素不存在则返回负数
        System.out.println(Collections.binarySearch(list, "zs1"));
        System.out.println(Collections.binarySearch(list, "zs99"));

    }
}
