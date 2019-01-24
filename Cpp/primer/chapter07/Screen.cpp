//#include<iostream>
//#include<string>
//#include<vector>
//using namespace std;
//
//class Screen
//{
//public:
//    // 类型成员要在使用前定义
//    typedef string::size_type pos;
//    // 等价于
//    // using pos = string::size_type;
//
//    Screen() = default;
//    Screen(pos ht, pos wd, char c):height(ht), width(wd),contents(ht*wd, c){};
//    char get() const
//    {
//        return contents[cursor];
//    }
//    inline char get(pos ht, pos wd)const;
//    Screen &move(pos r, pos c);
//    void some_menber()const;
//    Screen &set(char c);
//    Screen &set(pos r, pos col, char ch);
//    const Screen &diaplay() const;
//private:
//    pos cursor = 0;
//    pos height = 0, width = 0;
//    string contents;
//    mutable size_t access_ctr = 0;
//};
//
//class Window_mgr
//{
//private:
//    vector<Screen> screens{Screen(24, 80, ' ')};
//};
//
//int main()
//{
//    cout << "Program start:" << endl;
//
//    return 0;
//}
//
//inline char Screen::get(pos ht, pos wd)const
//{
//    pos row = ht * width;
//    return contents[row + wd];
//}
//
//Screen &Screen::move(pos r, pos c)
//{
//    pos row = r * width;
//    cursor = row + c;
//    return *this;
//}
//
//// 常成员函数不可以修改类内数据成员的值
//// 原因：
//// 类中的this指针本身是一个常指针，可以通过this指针修改类内数据成员
//// 但对于常成员函数来说,const限定符使得this指针变成了一个指向常对象的常指针
//// 所以不可以通过this指针修改数据成员的值
//// 即，常成员函数不可以修改数据成员值
//// 如果在某些情况下下必须要修改
//// 此时可以将相应的数据成员声明为mutable类型即可
//
//void Screen::some_menber()const
//{
//    ++access_ctr;
//}
//
//Screen &Screen::set(char c)
//{
//    contents[cursor] = c;
//    return *this;
//}
//
//Screen &Screen::set(pos r, pos col, char ch)
//{
//    contents[r * width + col] = ch;
//    return *this;
//}
//
//const Screen &Screen::diaplay() const
//{
//    cout << "123" << ' ';
//    return *this;
//}
