//#include<iostream>
//#include<string>
//#include<vector>
//using namespace std;
//
//class Screen
//{
//public:
//    // ���ͳ�ԱҪ��ʹ��ǰ����
//    typedef string::size_type pos;
//    // �ȼ���
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
//// ����Ա�����������޸��������ݳ�Ա��ֵ
//// ԭ��
//// ���е�thisָ�뱾����һ����ָ�룬����ͨ��thisָ���޸��������ݳ�Ա
//// �����ڳ���Ա������˵,const�޶���ʹ��thisָ������һ��ָ�򳣶���ĳ�ָ��
//// ���Բ�����ͨ��thisָ���޸����ݳ�Ա��ֵ
//// ��������Ա�����������޸����ݳ�Աֵ
//// �����ĳЩ������±���Ҫ�޸�
//// ��ʱ���Խ���Ӧ�����ݳ�Ա����Ϊmutable���ͼ���
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
