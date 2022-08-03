# LSP violation

One solution is to create a separate base generic repository for entities which have `int` ids.
And another base generic repository for entities with `Guid` ids.

Another solution is to not use generic repositories.
(If I remember correctly, Scott Millett has written something against generic repositories in his book PPPDDD.)
