#define CLAY_IMPLEMENTATION

// Force stdbool's `bool` type to be 4 bytes intead of 1
// this matches c#
#define _Bool int
#include "clay/clay.h"
