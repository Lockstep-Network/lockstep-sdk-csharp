/***
 * Lockstep Software Development Kit for C#
 *
 * (c) 2021-2022 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Ted Spence <tspence@lockstep.io>
 * @copyright  2021-2021 Lockstep, Inc.
 * @version    2021.39
 * @link       https://github.com/tspence/lockstep-sdk-csharp
 */

namespace LockstepSDK;

public class ErrorResult
{
    public string? Type { get; internal set; }
    public string? Title { get; internal set; }
    public int? Status { get; internal set; }
    public string? Detail { get; internal set; }
    public string? Instance { get; internal set; }
}

public class TestTimeoutException : ErrorResult {}
