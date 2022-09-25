// Some simple types (and literals)
let unsignedByte = 0b1111_1111uy
let signedByte = 0b1111_1111y

let unsignedShort = 0xffffus
let signedShort = 0xffffs

let unsigned = 0xffff_ffffu
let signed = 0xffff_ffff

let unsignedLong = 0xffff_ffff_ffff_ffffUL
let signedLong = 0xffff_ffff_ffff_ffffL

let float = 3.14f
let double = 2.718e3

let bigInt = 9999_9999_9999_9999_9999_9999I
let decimal = 1.414M

let unicodeChar = 'a'
let unicodeString = "A"

let asciiCharacter = 'a'B
let asciiString = "a"B

let verbatimAsciiString = @"\\server\share"B
let verbatimUnicodeString = @"\\server\share"

// Some objects from the BCL
let rightNow = System.DateTime.UtcNow
let aWrappedInt = box<int32> 1717

let aRng = System.Random()
let next (rng:System.Random) = rng.Next()
next aRng
