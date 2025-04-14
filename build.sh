set -e

echo "Applying patch"
git apply patches/remove-stdcall.patch

echo "Building"

gcc -shared -o libclay.so clay.c -fPIC

echo "Build finished"

echo "Generating pinvoke"
ClangSharpPInvokeGenerator @generate.rsp

echo "Reverting patch"
git checkout -- ./clay/clay.h
