# samples
android studio 关闭Instant Run

Go to Edit>Project Settings>Editor
In the inspector, change Version Control Mode to "Visible Meta Files"
If you have pro, change Asset Serialization Mode to Force Text

This will ensure that all your metadata is set in local metadata files, instead of in your Library folder. 
At this point, the Library folder becomes unnecessary to keep synced between users.
Now you can ignore these files in your preferred version control, including the entire Library folder:

Visible Meta Files 没有 Library/metadata
Hidden Meta Files 有 Library/metadata