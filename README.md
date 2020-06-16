# lbry.net
.net core SDK for lbry.io

# Example:

![bitcoinbrisbane](https://circleci.com/gh/bitcoinbrisbane/lbry.net.svg?style=svg)

[![bitcoinbrisbane](https://circleci.com/gh/bitcoinbrisbane/lbry.net.svg?style=svg)]


# Social Network

We will use lbry.io infrastructure to create decentralized social network using GPG and MIT's keybase server.  This of course could be keybase or other, but for simplicty we will use the aformentioned.

# Work flow

1. Create a new GPG keypair
2. Find a friend via their email on a keyserver
3. Create an encrypted messaging using our private key and their public key
4. Post that message to our lbry channel

## Installing GPG

`sudo apt-get install gnupg2`

## Create our own GPG Key

Our email for this will be `lucas@lucascullen.com`.  We create the key pair in bash using

`gpg --gen-key`

```
gpg: key D0DDC61FD0FFBDC7 marked as ultimately trusted
gpg: directory '/home/lucascullen/.gnupg/openpgp-revocs.d' created
gpg: revocation certificate stored as '/home/lucascullen/.gnupg/openpgp-revocs.d/764072BF5750190CB518F1BDD0DDC61FD0FFBDC7.rev'
public and secret key created and signed.

pub   rsa3072 2020-06-14 [SC] [expires: 2022-06-14]
      764072BF5750190CB518F1BDD0DDC61FD0FFBDC7
uid                      Lucas Cullen <lucas@lucascullen.com>
sub   rsa3072 2020-06-14 [E] [expires: 2022-06-14]
```

## Get a friends GPG Key

* bitcoinbrisbane lucas@bitcoinbrisbane.com.au

We can import the friends key from keybase using `curl https://keybase.io/bitcoinbrisbane/pgp_keys.asc | gpg --import`


## Create a text file

To create a simple "post", we will create a text file post.txt in the Files directory

`touch post.txt`

eg
```text
Hi all, in Vegas and its awesome!
```

## Encrypt the post

We will need to encrypt the file with each of our friends public key using

```gpg --encrypt --sign --armor -r lucas@bitcoinbrisbane.com.au post.txt```

You will then note in the Files directory the encrypted post.  We will need a stragey for sharing the post with many friends.

```text
-----BEGIN PGP MESSAGE-----

hQGMA3CBS/hSJn+GAQv+JPm9UhXFyk2BjoVMj2nbIYoMu2Mn0J86JziXhb7tgGj7
+DYH4/goxUkHnh3/l/QMpF5qozLM8RPm4ruGl9vNVNC51ajRjTyOs/9urVUGC8w6
0fDEKbc63SynIT8BaGjxmfrROZYWjcYVJAGW6UcyofKsIHCCuGAhCStpMDYcPV3V
aSwmryQhe8PnfynPtL59fjMZboAA2RYJ95SIZPO8hriSXA6uqA0EXcLFZcA0sqwC
EtDMG0JNhX0u87a8S00/w3KXYgs8kU2Ufyr1qRluNw8RYiG/hPcAN6P+t2Ta5iNl
Dj5QeKctmnNTzItBmuJPkNk9rDBPhFEKFNrGSMxzCbvpOqAkQXWV4GsvzYGnis/X
Da1HlO2uhHh7p5T8kESkuXgtgLz2LqAeFpcM/R33hQ0XlqyhVNZQYs+zaFTh8NgI
vNcDqpAU9ROP7p4lBUqJfKt6YZKLlRaKv+PnLIlV3uCbl8AlCBjRMuIKAHgkDe44
WyLNvbNPsWI8TTeuKRt60ukBS/1opBLSXjpOf2rWO8FDtF79b5KEhvgMWUt6xzAf
+oY+YRIwh+5HeKeuNwK3B8Xu9iDRj5a3tbVSKG4A1JfxGv6N6CsTWJxc014gahzM
1Zhxl4A8or4/JZq+XnPVOhwguA4E5oPRz/RmV0iVYThDOaoeOPmtTy/D0eN6Lv9j
y/OerrbrA6kDZYk3ovDc0Jtrni4Uvn2mMGyTjoqwXDXruWKkJESE/P9raMnDHZZG
oumVBZ23AVsfes/ft84fsdz/lABseQFRsKr6h9fjM8hnyANrSU5O462cS5RVQmHZ
oYKsOYNR/jDUTZJMgbCLPxHGf0GBqOHqqbdgfL8KKK/op1wFch8wtm5WLtk2S7Aw
jjcZ1u0HXc9p7yrYvISyGf9r8n9sKKC6eiOUCUorTUcuKb0FY+jHBARBD1e8Pj+0
2djvV5UzT3aO9XBrO+ZUMbcJyE1D4RmshvmKhcbqWwb6W0VX+T3rsNUvdd+RNptV
fkKUWSDSFlTTeV2DldB2TzDCkvmi7jDz+QrDwX5psbeT7uYLSXpFjAGQNkP1y6yw
qRuKwF5mN6fK+hTZWlfkC5BDAlZ1aNBlUajBF5pR/wi28bYEoJpKopF2xRr1UEAI
ovFBCfk5sM8JHgX8lj12QO2u7IrGFl+NrmVvXmnFGyzSw62xNqLONtfrTklNLyUd
oldNQwp16uIOgonz6XXMgkiYPl1HZ3NkDb9uGivIXX0EvFLWnNydR+AUVxdOajA0
Gn8m7uLXP50K30Kn4baMxIPnI8pgNrtaWHQ4OqXBYlLqGC0N8HmkTxk=
=c587
-----END PGP MESSAGE-----
```

## Create a mapping of lbry address / account

## Using lbry channels

For this I've created a simple channel `social` and the will upload the encrypted file to it via curl.

```curl -d'{"method": "publish", "params": {"name": "Post", "bid": "0.01", "file_path": "/home/lucascullen/GitHub/BitcoinBrisbane/lbry.net/Example/Files/post.txt.asc", "validate_file": false, "optimize_file": false, "tags": [], "languages": [], "locations": [], "channel_account_id": [], "funding_account_ids": [], "preview": false, "blocking": false}}' http://localhost:5279/```

## Friends

* bitcoinbrisbane lucas@bitcoinbrisbane.com.au

We can import the friends key from keybase using `curl https://keybase.io/bitcoinbrisbane/pgp_keys.asc | gpg --import`

```
-----BEGIN PGP PUBLIC KEY BLOCK-----
Comment: GPGTools - https://gpgtools.org

mQENBFMz/T4BCACx9JgfFyBCjVx0VbZeYDp6YlirrcliPBMuK+M1XZkdQQ8xuk9l
lxUyD5QSifDnZDZHoyIGVulzWAdFrugZLWx/84B4srDdp73NHleZE7BX9+YV6iVw
tGwRVMNVJWBC4esdQgaH87TPwqeTdzswGH2/BjI4FWwpMcS/xA2Ot95vp847NIX7
7nQ7VkLjNhLwURbimY5BQ+usUB9So4EYo/8QTNONeTS199bcUe+46i8zjE+heC7W
o3MgKrJAk5056L0M17L/ONlrUYlKPAfE4ju8eTK62u/mb8K3vEkmM5e4JEq7C1+P
Qbu9rxFzp3xfp6ldmppVVNpDboHWPwqS9sm9ABEBAAG0K0x1Y2FzIEN1bGxlbiA8
bHVjYXNAYml0Y29pbmJyaXNiYW5lLmNvbS5hdT6JAT0EEwEKACcFAlMz/T4CGwMF
CQeGH4AFCwkIBwMFFQoJCAsFFgIDAQACHgECF4AACgkQiBbfK1QQQJyaNgf/Za6s
96AiAWZOSA9sDPcFlmWuPFKPyq6HjVddpPP3TYhPhDxDVi9xUWGP9i0mn/D3j3YQ
VmsPIKzM4gNPRgkvygHnwKHHYgTf1LqQdGRdZ+H9mdILlb5gU79+yqzmpd7s1wN7
7ahdH89Ejq3kub7wIQBncVot2gQxLsioYlRmDEgNAtiA4gHZ9LSq3uKcN4Q3J/pT
C4gItQBlrSWlNLY49pMttVSJyzlERd10iDfyU/8hTWtb9vpH7dLqXkDxXtgzy0wK
rwHV2oVTqgFiHYWlxaeY9G2CEBxNchv52uIIBCFPz5MgNTvTdGCG7Dltvkt+eYPM
MtJPLG6dKzTA379XT7kBDQRTM/0+AQgAzTbwyXQizIj5tI7UKIzbM7PZS981WpN3
o2/odxWRaEncSjxnbGt8F74TF91iwX4AdyJiZYwnUGTZ8P5JsYz8aVtu28Flp30m
QL2yVkL4IllCnG7scUqMAQmmFBjLVuerbRjk6exYg+eZ3LOWhWeP5ZbU1+vbwCQp
zNdwuNhYF9Tksd02LMyEmiQUO//TGwDRNpjQqHKA6UHMXfp/95c0SNZ52uD62LxI
6rbhQd2zY6c3dMOka+JOQjlVgM8NEtlem7aJeW0GDpvzVPjwHjud6h5m3E6cdYZm
bvcRi4cuGKaJcpN6ixHa54MV8N3BQrzBGv9Dx4M9TLKUh6ZEcywJWQARAQABiQEl
BBgBCgAPBQJTM/0+AhsMBQkHhh+AAAoJEIgW3ytUEECclW4H/2AFFLumoLieaXLM
/n0lCNwso+gsnqQw2+/y1APAVkRej7y4uv/Tn3fosaTuccO05/8ZaTzygUCZStwl
+9Oc987QHw0M3KvVzIYthACM1URHDr4m7CuBLKn1JzVNydQihVEkPOJk7gGE5fhF
4T81ES3tIZ4sByVhB4h3ui/9YLcFMYWnjqZZ/G+V2rkZHQrHPb0Vtxyj+jzUundp
J5amqyblfs6e/jAUy5bRkRc+OfckZ664OhTVeYocxfdzyHN6twZjbYT7IJjwxIBh
uFHsnhQgHQ2eI8SgXZLlwkcXvlSJZW6Be+6iP6y1+7xbh6PWs4WYNFYnGwylnP6y
Ce1s2U0=
=5B88
-----END PGP PUBLIC KEY BLOCK-----
```

## GPG Keys





### Notes
https://www.digitalocean.com/community/tutorials/how-to-use-gpg-to-encrypt-and-sign-messages