#!/bin/bash

SOURCE_1="./dotnet"
SOURCE_2="./java"
SOURCE_3="./cpp"
DESTINATION="./code.tar"
LICENSE="./LICENSE"
FILES=""

if [ -e $DESTINATION ]
then
    rm $DESTINATION
fi

for i in `find "$SOURCE_1" -type f | grep -e '\.cs$' \
                                        -e '\.csproj$' \
                                        -e '\.sln$' \
                                 | grep -v './obj/.' \
                                 | grep -v './bin/.'`; do
    tar -rvf $DESTINATION $i
done

for i in `find "$SOURCE_2" -type f | grep -e '\.java$' \
                                 | grep -v './idea/.' \
                                 | grep -v './bin/.'`; do
    tar -rvf $DESTINATION $i
done

for i in `find "$SOURCE_3" -type f | grep -e '\.cpp$' \
                                        -e '\.h$' \
                                        -e '\.hpp$' \
                                 | grep -v './bin/.' \
                                 | grep -v './obj/.'`; do
    tar -rvf $DESTINATION $i
done

tar -rvf $DESTINATION $LICENSE
