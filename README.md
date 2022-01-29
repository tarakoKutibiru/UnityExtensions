# UnityExtensions

これはUnityの基本的なコンポーネントの拡張メソッド郡です。
Unityを使ったゲーム開発の効率を上げることが目的です。
個人的で実験的な試みなので、これを使って実際に開発効率が向上するかは分かりません。

This is a collection of extension methods for the basic components of Unity.
The purpose is to improve the efficiency of game development using Unity.
It's a personal and experimental attempt, so I don't know if it will actually improve development efficiency.

# Examples

## Before
```c#
void Update()
{
    if (this.IsOnGround())
    {
        Vector2 inputDirection = GetInputDirection();
        if (inputDirection.sqrMagnitude <= 0.1f)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var velocity = this.rb.velocity;
                velocity.y = this.jumpPower
                this.rb.velocity = velocity;
            }
            else
            {
                var velocity = this.rb.velocity;
                velocity.x = 0.0f;
                velocity.z = 0.0f;
                this.rb.velocity = velocity;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.rb.velocity = new Vector3(inputDirection.x * this.speed, this.jumpPower, inputDirection.y * this.speed);
            }
            else
            {
                this.rb.velocity = new Vector3(inputDirection.x * this.speed, this.rb.velocity.y, inputDirection.y * this.speed);
            }
        }
    }
}
```

## After
```c#
void Update()
{
    if (this.IsOnGround())
    {
        Vector2 inputDirection = GetInputDirection();
        if (inputDirection.sqrMagnitude <= 0.1f)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.rb.velocity = this.rb.velocity.SetY(this.jumpPower);
            }
            else
            {
                this.rb.velocity = this.rb.velocity.SetXZ(0);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.rb.velocity = inputDirection.ToVector3X0Y().MultiplyXZ(this.speed).SetY(this.jumpPower);
            }
            else
            {
                this.rb.velocity = inputDirection.ToVector3X0Y().MultiplyXZ(this.speed).SetY(this.rb.velocity.y);
            }
        }
    }
}
```

<br>
<br>
<br>

## Before
```c#
void PlayParticle()
{
    var position = this.transform.position;
    position.y = 0.0f;

    Instantiate<ParticleSystem>(this.particlePrefab, position,Quaternion.AngleAxis(-90, Vector3.left));
}
```

## After
```c#
void PlayParticle()
{
    this.particlePrefab.Instantiate<ParticleSystem>(this.transform.position.SetY(0.0f), Quaternion.AngleAxis(-90, Vector3.left));
}
```

or

```c#
void PlayParticle()
{
    this.particlePrefab.Instantiate<ParticleSystem>().transform.SetPosition(this.transform.position.SetY(0.0f)).SetRotation(Quaternion.AngleAxis(-90, Vector3.left));
}
```