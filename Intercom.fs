module Intercom


type UUID = UUID of string

type Member = {
    uuid: UUID
}

type Conference = {
    uuid: UUID
    members: Member list
}

type ProgramFeed = {
    uuid: UUID
}

type MixMinus=  Member | Conference

type Ifb = {
  uuid: UUID
  programFeed: ProgramFeed
  mixMinus: MixMinus
}

type Goup = {
    uuid: UUID
    members: Member list
}

type Source = 
| Member of Member
| Conference of Conference
| Ifb of Ifb


type Destination = 
| Member of Member
| Conference of COnference
| Group of Group
| Ifb of Ifb


type Talk = Source -> Destination

type Listen = Destination -> Source

type Duplex = {
    talk: Talk
    listen: Listen
}

type CrossPoint = {
    source: Source
    dst: Destination
}