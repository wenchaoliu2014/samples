# samples
android studio 关闭Instant Run

Go to Edit>Project Settings>Editor
In the inspector, change Version Control Mode to "Visible Meta Files"
If you have pro, change Asset Serialization Mode to Force Text

This will ensure that all your metadata is set in local metadata files, instead of in your Library folder. 
At this point, the Library folder becomes unnecessary to keep synced between users.
Now you can ignore these files in your preferred version control, including the entire Library folder:


一共有4种模式：

Hidden Meta Files：隐藏的Meta文件，即该文件的属性是隐藏的，在系统中如果不查看隐藏文件这些文件是看不到的。如果你不想看到这些Meta Files，你可以设置为该选项。
Visible Meta Files：可见的Meta文件。
Perforce：Unity内置的一种版本控制工具。
PlasticSCM：Unity内置的一种版本控制工具。