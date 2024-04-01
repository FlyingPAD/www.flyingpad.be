import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TagsWallComponent } from './tags-wall.component';

describe('TagsWallComponent', () => {
  let component: TagsWallComponent;
  let fixture: ComponentFixture<TagsWallComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TagsWallComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TagsWallComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
