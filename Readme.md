# Type-level natural numbers

Have you ever wanted to type-check your matrix multiplication? You can do that with type-level natural numbers.

## Example

<table>
    <thead>
        <tr>
            <th>F# code</th>
            <th>Result</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                <code>let matrix3x2 = Matrix&lt;int, Nat3, Nat2&gt;.Init(+)</code>
            </td>
            <td>
                <p>3 x 2 matrix:</p>
                <code>{ Values = [[0; 1]
            [1; 2]
            [2; 3]] }</code>
            </td>
        </tr>
        <tr>
            <td>
                <code>let matrix2x4 = Matrix&lt;int, Nat2, Nat4&gt;.Init(+)</code>
            </td>
            <td>
                <p>2 x 4 matrix:</p>
                <code>{ Values = [[0; 1; 2; 3]
            [1; 2; 3; 4]] }</code>
            </td>
        </tr>
        <tr>
            <td>
                <code>matrix3x2 * matrix2x4</code>
            </td>
            <td>
                <p>3 x 4 matrix:</p>
                <code>{ Values = [[1; 2; 3; 4]
            [2; 5; 8; 11]
            [3; 8; 13; 18]] }</code>
            </td>
        </tr>
        <tr>
            <td>
                <code>matrix2x4 * matrix3x2</code>
            </td>
            <td>
                <i>Compiler error!</i>
            </td>
        </tr>
    </tbody>
</table>
