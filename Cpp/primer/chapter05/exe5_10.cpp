// #include<iostream>
// #include<string>
// #include<iterator>
// #include<cctype>
// #include<typeinfo>
// using namespace std;

// int main()
// {
   // string str;
   // getline(cin, str);


   // string::iterator start = str.begin();
   // string::iterator stop = str.end();

   // int xcount = 0;
   // int scount = 0;
   // int tcount = 0;
   // int ecount = 0;
   // int ffcount = 0;
   // int flcount = 0;
   // int ficount = 0;
   // while(start != stop)
   // {
       // switch(*start)
       // {
           // case 'a':
           // case 'e':
           // case 'i':
           // case 'o':
           // case 'u':
           // case 'A':
           // case 'E':
           // case 'I':
           // case 'O':
           // case 'U': ++xcount; break;
           // case '\n': ++ecount; break;
           // case ' ': ++scount; break;
           // case '\t': ++tcount; break;
           // case 'f':
               // {
                   // if(*(start+1)=='f')
                   // {
                       // ++ffcount;
                       // ++start;
                   // }
                   // else
                   // {
                       // if(*(start+1)=='l')
                       // {
                           // ++flcount;
                           // ++start;
                       // }
                       // else
                       // {
                           // if(*(start+1)=='i')
                           // {
                               // ++ficount;
                               // ++start;
                           // }
                       // }
                   // }
               // }
           // default: break;
       // }
       // ++start;
   // }
   // cout << "vowelnum:" << xcount << endl;
   // cout << "spacenum:" << scount << endl;
   // cout << "enternum:" << ecount << endl;
   // cout << "Tabnum:" << tcount << endl;
   // cout << "ffcount:" << ffcount << endl;
   // cout << "flcount:" << flcount << endl;
   // cout << "ficount:" << ficount << endl;

   // return 0;
// }
