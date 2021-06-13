Partial port of LZ4 (`lib` subdirectory) version 1.9.3 to C#. See original LZ4 readme for details.
https://github.com/lz4/lz4/tree/v1.9.3

Intended for interaction with custom file formats that internally compress data with LZ4.

NOTE: Since this is managed C#, this is not going to win any speed awards, defeating most of the point of the LZ4 compression algorithm. If you need performance or intend to use this in an actual product, please just link to a native binary built from the original C code instead.
