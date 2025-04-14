set -e

echo "Building"

gcc -shared -o libclay.so clay.c -fPIC

echo "Build finished"

echo "Generating pinvoke"
ClangSharpPInvokeGenerator @generate.rsp
