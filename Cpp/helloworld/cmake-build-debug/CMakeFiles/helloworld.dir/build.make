# CMAKE generated file: DO NOT EDIT!
# Generated by "MinGW Makefiles" Generator, CMake Version 3.13

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:


#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:


# Remove some rules from gmake that .SUFFIXES does not remove.
SUFFIXES =

.SUFFIXES: .hpux_make_needs_suffix_list


# Suppress display of executed commands.
$(VERBOSE).SILENT:


# A target that is always out of date.
cmake_force:

.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

SHELL = cmd.exe

# The CMake executable.
CMAKE_COMMAND = "C:\Program Files\JetBrains\CLion 2018.3.4\bin\cmake\win\bin\cmake.exe"

# The command to remove a file.
RM = "C:\Program Files\JetBrains\CLion 2018.3.4\bin\cmake\win\bin\cmake.exe" -E remove -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = E:\JZS\Code\Cpp\helloworld

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = E:\JZS\Code\Cpp\helloworld\cmake-build-debug

# Include any dependencies generated for this target.
include CMakeFiles/helloworld.dir/depend.make

# Include the progress variables for this target.
include CMakeFiles/helloworld.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/helloworld.dir/flags.make

CMakeFiles/helloworld.dir/main.cpp.obj: CMakeFiles/helloworld.dir/flags.make
CMakeFiles/helloworld.dir/main.cpp.obj: ../main.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/helloworld.dir/main.cpp.obj"
	C:\MinGW\bin\g++.exe  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles\helloworld.dir\main.cpp.obj -c E:\JZS\Code\Cpp\helloworld\main.cpp

CMakeFiles/helloworld.dir/main.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/helloworld.dir/main.cpp.i"
	C:\MinGW\bin\g++.exe $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E E:\JZS\Code\Cpp\helloworld\main.cpp > CMakeFiles\helloworld.dir\main.cpp.i

CMakeFiles/helloworld.dir/main.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/helloworld.dir/main.cpp.s"
	C:\MinGW\bin\g++.exe $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S E:\JZS\Code\Cpp\helloworld\main.cpp -o CMakeFiles\helloworld.dir\main.cpp.s

CMakeFiles/helloworld.dir/helloworld.c.obj: CMakeFiles/helloworld.dir/flags.make
CMakeFiles/helloworld.dir/helloworld.c.obj: ../helloworld.c
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Building C object CMakeFiles/helloworld.dir/helloworld.c.obj"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -o CMakeFiles\helloworld.dir\helloworld.c.obj   -c E:\JZS\Code\Cpp\helloworld\helloworld.c

CMakeFiles/helloworld.dir/helloworld.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/helloworld.dir/helloworld.c.i"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E E:\JZS\Code\Cpp\helloworld\helloworld.c > CMakeFiles\helloworld.dir\helloworld.c.i

CMakeFiles/helloworld.dir/helloworld.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/helloworld.dir/helloworld.c.s"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S E:\JZS\Code\Cpp\helloworld\helloworld.c -o CMakeFiles\helloworld.dir\helloworld.c.s

CMakeFiles/helloworld.dir/数据类型.c.obj: CMakeFiles/helloworld.dir/flags.make
CMakeFiles/helloworld.dir/数据类型.c.obj: ../数据类型.c
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_3) "Building C object CMakeFiles/helloworld.dir/数据类型.c.obj"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -o CMakeFiles\helloworld.dir\数据类型.c.obj   -c E:\JZS\Code\Cpp\helloworld\数据类型.c

CMakeFiles/helloworld.dir/数据类型.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/helloworld.dir/数据类型.c.i"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E E:\JZS\Code\Cpp\helloworld\数据类型.c > CMakeFiles\helloworld.dir\数据类型.c.i

CMakeFiles/helloworld.dir/数据类型.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/helloworld.dir/数据类型.c.s"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S E:\JZS\Code\Cpp\helloworld\数据类型.c -o CMakeFiles\helloworld.dir\数据类型.c.s

CMakeFiles/helloworld.dir/取地址.c.obj: CMakeFiles/helloworld.dir/flags.make
CMakeFiles/helloworld.dir/取地址.c.obj: ../取地址.c
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_4) "Building C object CMakeFiles/helloworld.dir/取地址.c.obj"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -o CMakeFiles\helloworld.dir\取地址.c.obj   -c E:\JZS\Code\Cpp\helloworld\取地址.c

CMakeFiles/helloworld.dir/取地址.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/helloworld.dir/取地址.c.i"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E E:\JZS\Code\Cpp\helloworld\取地址.c > CMakeFiles\helloworld.dir\取地址.c.i

CMakeFiles/helloworld.dir/取地址.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/helloworld.dir/取地址.c.s"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S E:\JZS\Code\Cpp\helloworld\取地址.c -o CMakeFiles\helloworld.dir\取地址.c.s

CMakeFiles/helloworld.dir/浮点型数据.c.obj: CMakeFiles/helloworld.dir/flags.make
CMakeFiles/helloworld.dir/浮点型数据.c.obj: ../浮点型数据.c
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_5) "Building C object CMakeFiles/helloworld.dir/浮点型数据.c.obj"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -o CMakeFiles\helloworld.dir\浮点型数据.c.obj   -c E:\JZS\Code\Cpp\helloworld\浮点型数据.c

CMakeFiles/helloworld.dir/浮点型数据.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/helloworld.dir/浮点型数据.c.i"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E E:\JZS\Code\Cpp\helloworld\浮点型数据.c > CMakeFiles\helloworld.dir\浮点型数据.c.i

CMakeFiles/helloworld.dir/浮点型数据.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/helloworld.dir/浮点型数据.c.s"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S E:\JZS\Code\Cpp\helloworld\浮点型数据.c -o CMakeFiles\helloworld.dir\浮点型数据.c.s

CMakeFiles/helloworld.dir/运算符.c.obj: CMakeFiles/helloworld.dir/flags.make
CMakeFiles/helloworld.dir/运算符.c.obj: ../运算符.c
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_6) "Building C object CMakeFiles/helloworld.dir/运算符.c.obj"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -o CMakeFiles\helloworld.dir\运算符.c.obj   -c E:\JZS\Code\Cpp\helloworld\运算符.c

CMakeFiles/helloworld.dir/运算符.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/helloworld.dir/运算符.c.i"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E E:\JZS\Code\Cpp\helloworld\运算符.c > CMakeFiles\helloworld.dir\运算符.c.i

CMakeFiles/helloworld.dir/运算符.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/helloworld.dir/运算符.c.s"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S E:\JZS\Code\Cpp\helloworld\运算符.c -o CMakeFiles\helloworld.dir\运算符.c.s

CMakeFiles/helloworld.dir/循环结构.c.obj: CMakeFiles/helloworld.dir/flags.make
CMakeFiles/helloworld.dir/循环结构.c.obj: ../循环结构.c
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_7) "Building C object CMakeFiles/helloworld.dir/循环结构.c.obj"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -o CMakeFiles\helloworld.dir\循环结构.c.obj   -c E:\JZS\Code\Cpp\helloworld\循环结构.c

CMakeFiles/helloworld.dir/循环结构.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/helloworld.dir/循环结构.c.i"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E E:\JZS\Code\Cpp\helloworld\循环结构.c > CMakeFiles\helloworld.dir\循环结构.c.i

CMakeFiles/helloworld.dir/循环结构.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/helloworld.dir/循环结构.c.s"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S E:\JZS\Code\Cpp\helloworld\循环结构.c -o CMakeFiles\helloworld.dir\循环结构.c.s

CMakeFiles/helloworld.dir/选择结构.c.obj: CMakeFiles/helloworld.dir/flags.make
CMakeFiles/helloworld.dir/选择结构.c.obj: ../选择结构.c
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_8) "Building C object CMakeFiles/helloworld.dir/选择结构.c.obj"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -o CMakeFiles\helloworld.dir\选择结构.c.obj   -c E:\JZS\Code\Cpp\helloworld\选择结构.c

CMakeFiles/helloworld.dir/选择结构.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/helloworld.dir/选择结构.c.i"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E E:\JZS\Code\Cpp\helloworld\选择结构.c > CMakeFiles\helloworld.dir\选择结构.c.i

CMakeFiles/helloworld.dir/选择结构.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/helloworld.dir/选择结构.c.s"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S E:\JZS\Code\Cpp\helloworld\选择结构.c -o CMakeFiles\helloworld.dir\选择结构.c.s

CMakeFiles/helloworld.dir/成绩评级系统.c.obj: CMakeFiles/helloworld.dir/flags.make
CMakeFiles/helloworld.dir/成绩评级系统.c.obj: ../成绩评级系统.c
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_9) "Building C object CMakeFiles/helloworld.dir/成绩评级系统.c.obj"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -o CMakeFiles\helloworld.dir\成绩评级系统.c.obj   -c E:\JZS\Code\Cpp\helloworld\成绩评级系统.c

CMakeFiles/helloworld.dir/成绩评级系统.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/helloworld.dir/成绩评级系统.c.i"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E E:\JZS\Code\Cpp\helloworld\成绩评级系统.c > CMakeFiles\helloworld.dir\成绩评级系统.c.i

CMakeFiles/helloworld.dir/成绩评级系统.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/helloworld.dir/成绩评级系统.c.s"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S E:\JZS\Code\Cpp\helloworld\成绩评级系统.c -o CMakeFiles\helloworld.dir\成绩评级系统.c.s

CMakeFiles/helloworld.dir/选择结构2.c.obj: CMakeFiles/helloworld.dir/flags.make
CMakeFiles/helloworld.dir/选择结构2.c.obj: ../选择结构2.c
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_10) "Building C object CMakeFiles/helloworld.dir/选择结构2.c.obj"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -o CMakeFiles\helloworld.dir\选择结构2.c.obj   -c E:\JZS\Code\Cpp\helloworld\选择结构2.c

CMakeFiles/helloworld.dir/选择结构2.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/helloworld.dir/选择结构2.c.i"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E E:\JZS\Code\Cpp\helloworld\选择结构2.c > CMakeFiles\helloworld.dir\选择结构2.c.i

CMakeFiles/helloworld.dir/选择结构2.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/helloworld.dir/选择结构2.c.s"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S E:\JZS\Code\Cpp\helloworld\选择结构2.c -o CMakeFiles\helloworld.dir\选择结构2.c.s

CMakeFiles/helloworld.dir/跳转goto.c.obj: CMakeFiles/helloworld.dir/flags.make
CMakeFiles/helloworld.dir/跳转goto.c.obj: ../跳转goto.c
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_11) "Building C object CMakeFiles/helloworld.dir/跳转goto.c.obj"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -o CMakeFiles\helloworld.dir\跳转goto.c.obj   -c E:\JZS\Code\Cpp\helloworld\跳转goto.c

CMakeFiles/helloworld.dir/跳转goto.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/helloworld.dir/跳转goto.c.i"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E E:\JZS\Code\Cpp\helloworld\跳转goto.c > CMakeFiles\helloworld.dir\跳转goto.c.i

CMakeFiles/helloworld.dir/跳转goto.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/helloworld.dir/跳转goto.c.s"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S E:\JZS\Code\Cpp\helloworld\跳转goto.c -o CMakeFiles\helloworld.dir\跳转goto.c.s

CMakeFiles/helloworld.dir/数组.c.obj: CMakeFiles/helloworld.dir/flags.make
CMakeFiles/helloworld.dir/数组.c.obj: ../数组.c
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_12) "Building C object CMakeFiles/helloworld.dir/数组.c.obj"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -o CMakeFiles\helloworld.dir\数组.c.obj   -c E:\JZS\Code\Cpp\helloworld\数组.c

CMakeFiles/helloworld.dir/数组.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/helloworld.dir/数组.c.i"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E E:\JZS\Code\Cpp\helloworld\数组.c > CMakeFiles\helloworld.dir\数组.c.i

CMakeFiles/helloworld.dir/数组.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/helloworld.dir/数组.c.s"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S E:\JZS\Code\Cpp\helloworld\数组.c -o CMakeFiles\helloworld.dir\数组.c.s

CMakeFiles/helloworld.dir/二维数组.c.obj: CMakeFiles/helloworld.dir/flags.make
CMakeFiles/helloworld.dir/二维数组.c.obj: ../二维数组.c
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_13) "Building C object CMakeFiles/helloworld.dir/二维数组.c.obj"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -o CMakeFiles\helloworld.dir\二维数组.c.obj   -c E:\JZS\Code\Cpp\helloworld\二维数组.c

CMakeFiles/helloworld.dir/二维数组.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/helloworld.dir/二维数组.c.i"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E E:\JZS\Code\Cpp\helloworld\二维数组.c > CMakeFiles\helloworld.dir\二维数组.c.i

CMakeFiles/helloworld.dir/二维数组.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/helloworld.dir/二维数组.c.s"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S E:\JZS\Code\Cpp\helloworld\二维数组.c -o CMakeFiles\helloworld.dir\二维数组.c.s

CMakeFiles/helloworld.dir/数组之间的赋值.c.obj: CMakeFiles/helloworld.dir/flags.make
CMakeFiles/helloworld.dir/数组之间的赋值.c.obj: ../数组之间的赋值.c
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_14) "Building C object CMakeFiles/helloworld.dir/数组之间的赋值.c.obj"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -o CMakeFiles\helloworld.dir\数组之间的赋值.c.obj   -c E:\JZS\Code\Cpp\helloworld\数组之间的赋值.c

CMakeFiles/helloworld.dir/数组之间的赋值.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/helloworld.dir/数组之间的赋值.c.i"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E E:\JZS\Code\Cpp\helloworld\数组之间的赋值.c > CMakeFiles\helloworld.dir\数组之间的赋值.c.i

CMakeFiles/helloworld.dir/数组之间的赋值.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/helloworld.dir/数组之间的赋值.c.s"
	C:\MinGW\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S E:\JZS\Code\Cpp\helloworld\数组之间的赋值.c -o CMakeFiles\helloworld.dir\数组之间的赋值.c.s

# Object files for target helloworld
helloworld_OBJECTS = \
"CMakeFiles/helloworld.dir/main.cpp.obj" \
"CMakeFiles/helloworld.dir/helloworld.c.obj" \
"CMakeFiles/helloworld.dir/数据类型.c.obj" \
"CMakeFiles/helloworld.dir/取地址.c.obj" \
"CMakeFiles/helloworld.dir/浮点型数据.c.obj" \
"CMakeFiles/helloworld.dir/运算符.c.obj" \
"CMakeFiles/helloworld.dir/循环结构.c.obj" \
"CMakeFiles/helloworld.dir/选择结构.c.obj" \
"CMakeFiles/helloworld.dir/成绩评级系统.c.obj" \
"CMakeFiles/helloworld.dir/选择结构2.c.obj" \
"CMakeFiles/helloworld.dir/跳转goto.c.obj" \
"CMakeFiles/helloworld.dir/数组.c.obj" \
"CMakeFiles/helloworld.dir/二维数组.c.obj" \
"CMakeFiles/helloworld.dir/数组之间的赋值.c.obj"

# External object files for target helloworld
helloworld_EXTERNAL_OBJECTS =

helloworld.exe: CMakeFiles/helloworld.dir/main.cpp.obj
helloworld.exe: CMakeFiles/helloworld.dir/helloworld.c.obj
helloworld.exe: CMakeFiles/helloworld.dir/数据类型.c.obj
helloworld.exe: CMakeFiles/helloworld.dir/取地址.c.obj
helloworld.exe: CMakeFiles/helloworld.dir/浮点型数据.c.obj
helloworld.exe: CMakeFiles/helloworld.dir/运算符.c.obj
helloworld.exe: CMakeFiles/helloworld.dir/循环结构.c.obj
helloworld.exe: CMakeFiles/helloworld.dir/选择结构.c.obj
helloworld.exe: CMakeFiles/helloworld.dir/成绩评级系统.c.obj
helloworld.exe: CMakeFiles/helloworld.dir/选择结构2.c.obj
helloworld.exe: CMakeFiles/helloworld.dir/跳转goto.c.obj
helloworld.exe: CMakeFiles/helloworld.dir/数组.c.obj
helloworld.exe: CMakeFiles/helloworld.dir/二维数组.c.obj
helloworld.exe: CMakeFiles/helloworld.dir/数组之间的赋值.c.obj
helloworld.exe: CMakeFiles/helloworld.dir/build.make
helloworld.exe: CMakeFiles/helloworld.dir/linklibs.rsp
helloworld.exe: CMakeFiles/helloworld.dir/objects1.rsp
helloworld.exe: CMakeFiles/helloworld.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_15) "Linking CXX executable helloworld.exe"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles\helloworld.dir\link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/helloworld.dir/build: helloworld.exe

.PHONY : CMakeFiles/helloworld.dir/build

CMakeFiles/helloworld.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles\helloworld.dir\cmake_clean.cmake
.PHONY : CMakeFiles/helloworld.dir/clean

CMakeFiles/helloworld.dir/depend:
	$(CMAKE_COMMAND) -E cmake_depends "MinGW Makefiles" E:\JZS\Code\Cpp\helloworld E:\JZS\Code\Cpp\helloworld E:\JZS\Code\Cpp\helloworld\cmake-build-debug E:\JZS\Code\Cpp\helloworld\cmake-build-debug E:\JZS\Code\Cpp\helloworld\cmake-build-debug\CMakeFiles\helloworld.dir\DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/helloworld.dir/depend

