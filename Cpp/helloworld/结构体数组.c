////
//// Created by shuncs on 19-2-28.
////
//
//#include <stdio.h>
//#include <string.h>
//
//struct Teach
//{
//    char tName[10];
//    int tAge;
//};
//
//int main(void)
//{
//    struct Teach teach[3] = {{"jethro", 25}, {"johnson", 26}, {"tomas", 27}};
//    struct Teach (*pt)[3] = &teach;
//    for(int i=0;i<3;i++)
//    {
//        printf("%s\t%d\n", (*pt)[i].tName, (*((*pt)+i)).tAge);
//    }
//
//    return 0;
//}