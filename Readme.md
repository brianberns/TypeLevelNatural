# Type-level natural numbers

Have you ever wanted to type-check your matrix multiplication? You can do that with type-level natural numbers.

## Example

<table>
    <thead>
        <tr>
            <th>Code</th>
            <th>Result</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                <code>
                    let matrix3x2 = Matrix<int, Nat3, Nat2>.Init(+)
                </code>
            </td>
            <td>
                <code>
                { Values = [[0; 1]
                            [1; 2]
                            [2; 3]] }
                </code>
            </td>
        </tr>
        <tr>
            <td>
                <code>
                    let matrix2x4 = Matrix<int, Nat2, Nat4>.Init(+)
                </code>
            </td>
            <td>
                <code>
                { Values = [[0; 1; 2; 3]
                            [1; 2; 3; 4]] }
                </code>
            </td>
        </tr>
        <tr>
            <td>
                <code>
                    matrix3x2 * matrix2x4
                </code>
            </td>
            <td>
                <code>
                { Values = [[1; 2; 3; 4]
                            [2; 5; 8; 11]
                            [3; 8; 13; 18]] }
                </code>
            </td>
        </tr>
        <tr>
            <td>
                <code>
                    matrix2x4 * matrix3x2
                </code>
            </td>
            <td>
                Compiler error!
            </td>
        </tr>
    </tbody>
</table>
